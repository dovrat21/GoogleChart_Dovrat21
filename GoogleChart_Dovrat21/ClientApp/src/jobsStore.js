

export function createJobsStore() {
    return {
        outputData: [],

        check(data) {
            var ordered =  data.sort(({ id: a }, { id: b }) => a <b);
            
        },
        
        async getJobs() {
           
            //Promise.all([activeJobs, jobsViews]).then(values => {
            //    /*console.log(value);*/
            //    debugger
            //    return Promise.all(values.map(r => r.clone().json()));
            //}).then(([active, views]) => { debugger; console.log(active); console.log(views) });

         
            const activeJobs = await fetch('campaignJobs');
            const active = await activeJobs.clone().json();
            const jobsViews = await fetch('campaignJobs/id');
            const views = await jobsViews.clone().json();
            const predictedViews = await fetch('campaignJobs/id/name');
            const predicted = await predictedViews.clone().json();

            
          
            this.outputData.push(["x", "Active Jobes", "predicted job views","job views"]);
            for (var i = 0; i < active.length; i++) {
                 var line = {
                    ...active[i],
                     ...views[i],
                     ...predicted[i]
                };
               
                this.outputData.push([line.date, line.activeJobCounter, line.jobsViewsCounter, line.predictedJobViewCounter]);
                
            }
        
        }
    }
}