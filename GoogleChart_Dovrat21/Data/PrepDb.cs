using GoogleChart_Dovrat21.Models;
using Microsoft.EntityFrameworkCore;

namespace GoogleChart_Dovrat21.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(WebApplication app)
        {
            using (var serviceScope = app.Services.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>(),
                        app.Environment.IsProduction());
            }
        }

        private static void SeedData(AppDbContext dbContext, bool isProduction = false)
        {
            if (!isProduction)
            {
                if (!dbContext.ActiveJobs.Any())
                {
                    Console.WriteLine("--> Seeding data on In-Memory Database ...");

                    dbContext.ActiveJobs.AddRange(
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 50, Date="May 1" },
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 70, Date = "May 2" },
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 90, Date = "May 3" },
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 100, Date = "May 4" },
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 120, Date = "May 5" },
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 170, Date = "May 6" },
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 200, Date = "May 7" },
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 250, Date = "May 8" },
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 300, Date = "May 9" },
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 350, Date = "May 10" },
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 370, Date = "May 11" },
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 390, Date = "May 12" },
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 400, Date = "May 13" },
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 410, Date = "May 14" },
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 420, Date = "May 15" }
                    );

                    dbContext.SaveChanges();
                }
                else
                {
                    Console.WriteLine("--> We already have data.");
                }
                if (!dbContext.JobsViews.Any())
                {
                        Console.WriteLine("--> Seeding data on In-Memory Database ...");
                    dbContext.JobsViews.AddRange(
                        new jobView { Id= 1, Source = "Linkedin", JobsViewsCounter=120, Date = "May 1" },
                        new jobView { Id = 2,Source = "Linkedin", JobsViewsCounter = 170, Date = "May 2" },
                        new jobView { Id = 3, Source = "JobMaster", JobsViewsCounter = 180, Date = "May 3" },
                        new jobView { Id = 4, Source = "Linkedin", JobsViewsCounter = 200, Date = "May 4" },
                        new jobView { Id = 5, Source = "Linkedin", JobsViewsCounter = 220, Date = "May 5" },
                        new jobView { Id = 6, Source = "Linkedin", JobsViewsCounter = 240, Date = "May 6" },
                        new jobView { Id = 7, Source = "Linkedin", JobsViewsCounter = 400, Date = "May 7" },
                        new jobView { Id = 8, Source = "Adds",     JobsViewsCounter = 500, Date = "May 8" },
                        new jobView { Id = 9, Source = "Adds",     JobsViewsCounter = 600, Date = "May 9" },
                        new jobView { Id = 10, Source = "Adds",     JobsViewsCounter = 620, Date = "May 10" },
                        new jobView { Id = 11, Source = "JobMaster",JobsViewsCounter = 640, Date = "May 11" },
                        new jobView { Id = 12, Source = "Adds",     JobsViewsCounter = 680, Date = "May 12" },
                        new jobView { Id = 13, Source = "Linkedin", JobsViewsCounter = 700, Date = "May 13" },
                        new jobView { Id = 14, Source = "JobMaster",JobsViewsCounter = 710, Date = "May 14" },
                        new jobView { Id = 15, Source = "Linkedin", JobsViewsCounter = 720, Date = "May 15" }
                    );

                      dbContext.SaveChanges();
                    }
                else
                {
                   Console.WriteLine("--> We already have data.");
                }
                if (!dbContext.PredictedJobViews.Any())
                {
                    Console.WriteLine("--> Seeding data on In-Memory Database ...");
                    dbContext.PredictedJobViews.AddRange(
                        new PredictedJobView { Id = 1, Name = "E", PredictedJobViewCounter = 150, Date = "May 1" },
                        new PredictedJobView { Id = 2, Name = "E", PredictedJobViewCounter = 400, Date = "May 2" },
                        new PredictedJobView { Id = 3, Name = "E", PredictedJobViewCounter = 450, Date = "May 3" },
                        new PredictedJobView { Id = 4, Name = "F", PredictedJobViewCounter = 500, Date = "May 4" },
                        new PredictedJobView { Id = 5, Name = "T", PredictedJobViewCounter = 550, Date = "May 5" },
                        new PredictedJobView { Id = 6, Name = "G", PredictedJobViewCounter = 600, Date = "May 6" },
                        new PredictedJobView { Id = 7, Name = "H", PredictedJobViewCounter = 601, Date = "May 7" },
                        new PredictedJobView { Id = 8, Name = "G", PredictedJobViewCounter = 602, Date = "May 8" },
                        new PredictedJobView { Id = 9, Name = "G", PredictedJobViewCounter = 610, Date = "May 9" },
                        new PredictedJobView { Id = 10, Name = "G", PredictedJobViewCounter = 700, Date = "May 10" },
                        new PredictedJobView { Id = 11, Name = "H", PredictedJobViewCounter = 720, Date = "May 11" },
                        new PredictedJobView { Id = 12, Name = "A", PredictedJobViewCounter = 740, Date = "May 12" },
                        new PredictedJobView { Id = 13, Name = "G", PredictedJobViewCounter = 800, Date = "May 13" },
                        new PredictedJobView { Id = 14, Name = "J", PredictedJobViewCounter = 900, Date = "May 14" },
                        new PredictedJobView { Id = 15, Name = "A", PredictedJobViewCounter = 1000, Date = "May 15" }
                    );

                    dbContext.SaveChanges();
                }
                else
                {
                    Console.WriteLine("--> We already have data.");
                }
            }
            else
            {
                Console.WriteLine("---> Attempting to apply migrations to SQL Server Database ...");
                try
                {
                    dbContext.Database.Migrate();
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"---> Cannot run migrations: {exception.Message}. ");
                }
            }
        }
    }
}
