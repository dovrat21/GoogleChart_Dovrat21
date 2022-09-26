using GoogleChart_Dovrat21.Models;

namespace GoogleChart_Dovrat21.Data
{
    public interface IActiveJobsRepo
    {
        bool SaveChanges();

        IEnumerable<ActiveJob> GetAllActiveJobs();
        void CreateActiveJobs(ActiveJob newActiveJobs);
    }
}
