using GoogleChart_Dovrat21.Models;

namespace GoogleChart_Dovrat21.Data
{
    public class JobsViewsRepo: IJobsViewsRepo
    {
        private readonly AppDbContext _dbContext;

        public JobsViewsRepo(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateJobView(jobView newJobView)
        {
            if (newJobView == null)
            {
                throw new ArgumentNullException(nameof(newJobView));
            }

            _dbContext?.JobsViews?.Add(newJobView);
        }
       

        public IEnumerable<jobView> GetAllJobsViews()
        {
            return _dbContext?.JobsViews?.ToList(); ;
        }

        public bool SaveChanges() => _dbContext.SaveChanges() >= 0;
    }
}
