using GoogleChart_Dovrat21.Models;
using Microsoft.EntityFrameworkCore;

namespace GoogleChart_Dovrat21.Data
{
    public class AppDbContext: DbContext
    {
        
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
            }

            public DbSet<ActiveJob>? ActiveJobs { set; get; }

            public DbSet<jobView>? JobsViews { set; get; }

            public DbSet<PredictedJobView>? PredictedJobViews { set; get; }

    }
}
