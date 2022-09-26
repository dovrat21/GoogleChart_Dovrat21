import React from 'react'
import { createJobsStore } from './jobsStore'
import { useLocalStore } from 'mobx-react'

const JobsContext = React.createContext(null)

export const JobssProvider = ({ children }) => {
    const jobsStore = useLocalStore(createJobsStore)

    return <JobsContext.Provider value={jobsStore}>
        {children}
    </JobsContext.Provider>
}

export const useJobsStore = () => React.useContext(JobsContext);