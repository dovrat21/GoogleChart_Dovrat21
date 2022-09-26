import React, { useState, useEffect } from 'react';

//import { Route, Routes } from 'react-router-dom';
//import AppRoutes from './AppRoutes';
//import { Layout } from './components/Layout';
import { Jobs } from './components/Jobs';
import { useObserver } from "mobx-react";
import './custom.css';





const App = () => {

    return useObserver(() => (
      
        <div>
         
            <Jobs />
      
        </div>
    ));

}
export default App;

