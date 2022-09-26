using GoogleChart_Dovrat21.Models;

namespace GoogleChart_Dovrat21.Data
{
    public interface IPredictedJobViewRepo
    {
        bool SaveChanges();

        IEnumerable<PredictedJobView> GetAllPredictedJobView();
    }
}
