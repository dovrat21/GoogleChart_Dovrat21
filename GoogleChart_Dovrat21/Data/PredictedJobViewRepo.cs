using GoogleChart_Dovrat21.Models;

namespace GoogleChart_Dovrat21.Data
{
    public class PredictedJobViewRepo : IPredictedJobViewRepo
    {
        private readonly AppDbContext _dbContext;

        public PredictedJobViewRepo(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<PredictedJobView> GetAllPredictedJobView()
        {
            return _dbContext?.PredictedJobViews?.ToList(); ;
        }

        public bool SaveChanges() => _dbContext.SaveChanges() >= 0;
    }
}
