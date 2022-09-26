using GoogleChart_Dovrat21.Models;

namespace GoogleChart_Dovrat21.Data
{
    public interface IJobsViewsRepo
    {
        bool SaveChanges();

        IEnumerable<jobView> GetAllJobsViews();
       
    }
}
