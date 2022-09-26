using GoogleChart_Dovrat21.Models;

namespace GoogleChart_Dovrat21.Data
{
    public class ActiveJobsRepo : IActiveJobsRepo
    {
        private readonly AppDbContext _dbContext;

        public ActiveJobsRepo(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateActiveJobs(ActiveJob newActiveJob)
        {
            if (newActiveJob == null)
            {
                throw new ArgumentNullException(nameof(newActiveJob));
            }

            _dbContext?.ActiveJobs?.Add(newActiveJob);
        }
        public IEnumerable<ActiveJob>? GetAllActiveJobs() {
            return _dbContext?.ActiveJobs?.ToList();
        }
        //public IEnumerable<ActiveJob> GetAllActiveJobs() => _dbContext?.ActiveJobs?.ToList();


        public bool SaveChanges() => _dbContext.SaveChanges() >= 0;
    }
}
