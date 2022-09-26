import React, { useState, useEffect } from "react";
import { Chart } from "react-google-charts";
import { useJobsStore } from "../JobsContext";
import { useObserver } from "mobx-react";
import './NavMenu.css';


export const Jobs = () => {
   
 
    const notesStore = useJobsStore();
   
    const options = {

        focusTarget: 'category',
        title: "Cumulative jobs views vs. prediction",
        vAxes: {
            0: { title: "job views" },
            1: { title: "jobs" }
         },
        seriesType: "bars",
        pointSize: 10,
        curveType: 'function',
        legend: { position: "bottom" },
        series: {
            1: { type: "line", lineDashStyle: [2, 2], targetAxisIndex: 0, pointShape: 'circle', sides: 4 },
            2: { type: "line", targetAxisIndex: 1, pointShape: 'circle'}
        },
    };

    useEffect(() => {
        notesStore.getJobs();
       
        return () => {
            // this now gets called when the component unmounts
        };
    }, []);


    return useObserver(() => (
        <div className="App">

            <ul className ="myList">
                {notesStore.outputData.map((note) => (

                    <li>{note.join(' ') }</li>
                ))}
            </ul>
                        
            <Chart
                chartType="ComboChart"
                width="90%"
                height="70vh"
                data={notesStore.outputData}
                options={options}
            />
            <h1>Dovrat Gratziany</h1>
        </div>
    ));

}
export default Jobs;

