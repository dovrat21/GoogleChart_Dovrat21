

export function createJobsStore() {
    return {
        outputData: [],

        async getJobs() {
            
            var dict = {"01": "Jan","02": "Feb","03": "Mar","04": "Apr","05": "May","06": "jun", "07": "jul","08": "Aug","09": "Sep","10": "Oct","11": "Nov","12": "Dec"};
           
            //Promise.all([activeJobs, jobsViews]).then(values => {
            //    /*console.log(value);*/
            //    debugger
            //    return Promise.all(values.map(r => r.clone().json()));
            //}).then(([active, views]) => { debugger; console.log(active); console.log(views) });

         
            const activeJobs = await fetch('campaignJobs');
            const active = await activeJobs.json();
            const jobsViews = await fetch('campaignJobs/id');
            const views = await jobsViews.clone().json();
            const predictedViews = await fetch('campaignJobs/id/name');
            const predicted = await predictedViews.clone().json();

            
            //this.outputData.push(["x", "Active Jobes"]);
            this.outputData.push(["x", "Active Jobes", "predicted job views","job views"]);
            for (var i = 0; i < active.length; i++) {
                 var line = {
                    ...active[i],
                    ...views[i],
                    ...predicted[i]
                };
                var date = dict[active[i].date.substr(5, 2)] + " " + active[i].date.substr(8, 2);
                this.outputData.push([date, line.activeJobCounter, line.jobsViewsCounter, line.predictedJobViewCounter]);
               
            }
        
        }
    }
}