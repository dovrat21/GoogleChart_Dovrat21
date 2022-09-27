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
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 50, Date = new DateTime(2022,05, 01)},
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 70, Date = new DateTime(2022,05, 02) },
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 90, Date = new DateTime(2022,05, 03) },
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 100,Date = new DateTime(2022,05, 04) },
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 120, Date = new DateTime(2022,05,05) },
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 170, Date = new DateTime(02022,05,06) },
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 200, Date = new DateTime(2022,05, 07) },
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 250, Date = new DateTime(2022,05, 08) },
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 300, Date = new DateTime(2022,05, 09) },
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 350, Date = new DateTime(2022,05, 10) },
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 370, Date = new DateTime(2022,05, 11) },
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 390, Date = new DateTime(2022,05, 12) },
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 400, Date = new DateTime(2022,05, 13) },
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 410, Date = new DateTime(2022,05, 14) },
                        new ActiveJob { Name = "Active job", ActiveJobCounter = 420, Date = new DateTime(2022,05, 15) }
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
                        new jobView { Id= 1, Source = "Linkedin", JobsViewsCounter=120, Date = new DateTime(2022, 05, 01) },
                        new jobView { Id = 2,Source = "Linkedin", JobsViewsCounter = 170, Date = new DateTime(2022, 05, 02) },
                        new jobView { Id = 3, Source = "JobMaster", JobsViewsCounter = 180, Date = new DateTime(2022, 05, 03) },
                        new jobView { Id = 4, Source = "Linkedin", JobsViewsCounter = 200, Date = new DateTime(2022, 05, 04) },
                        new jobView { Id = 5, Source = "Linkedin", JobsViewsCounter = 220, Date = new DateTime(2022, 05, 05) },
                        new jobView { Id = 6, Source = "Linkedin", JobsViewsCounter = 240, Date = new DateTime(2022, 05, 06) },
                        new jobView { Id = 7, Source = "Linkedin", JobsViewsCounter = 400, Date = new DateTime(2022, 05, 07) },
                        new jobView { Id = 8, Source = "Adds",     JobsViewsCounter = 500, Date = new DateTime(2022, 05, 08) },
                        new jobView { Id = 9, Source = "Adds",     JobsViewsCounter = 600, Date = new DateTime(2022, 05, 09) },
                        new jobView { Id = 10, Source = "Adds",     JobsViewsCounter = 620, Date = new DateTime(2022, 05, 10) },
                        new jobView { Id = 11, Source = "JobMaster",JobsViewsCounter = 640, Date = new DateTime(2022, 05, 11) },
                        new jobView { Id = 12, Source = "Adds",     JobsViewsCounter = 680, Date = new DateTime(2022, 05, 12) },
                        new jobView { Id = 13, Source = "Linkedin", JobsViewsCounter = 700, Date = new DateTime(2022, 05, 13) },
                        new jobView { Id = 14, Source = "JobMaster",JobsViewsCounter = 710, Date = new DateTime(2022, 05, 14) },
                        new jobView { Id = 15, Source = "Linkedin", JobsViewsCounter = 720, Date = new DateTime(2022, 05, 15) }
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
                        new PredictedJobView { Id = 1, Name = "E", PredictedJobViewCounter = 150, Date = new DateTime(2022, 05, 01) },
                        new PredictedJobView { Id = 2, Name = "E", PredictedJobViewCounter = 400, Date = new DateTime(2022, 05, 02) },
                        new PredictedJobView { Id = 3, Name = "E", PredictedJobViewCounter = 450, Date = new DateTime(2022, 05, 03) },
                        new PredictedJobView { Id = 4, Name = "F", PredictedJobViewCounter = 500, Date = new DateTime(2022, 05, 04) },
                        new PredictedJobView { Id = 5, Name = "T", PredictedJobViewCounter = 550, Date = new DateTime(2022, 05, 05) },
                        new PredictedJobView { Id = 6, Name = "G", PredictedJobViewCounter = 600, Date = new DateTime(2022, 05, 06) },
                        new PredictedJobView { Id = 7, Name = "H", PredictedJobViewCounter = 601, Date = new DateTime(2022, 05, 07) },
                        new PredictedJobView { Id = 8, Name = "G", PredictedJobViewCounter = 602, Date = new DateTime(2022, 05, 08) },
                        new PredictedJobView { Id = 9, Name = "G", PredictedJobViewCounter = 610, Date = new DateTime(2022, 05, 09) },
                        new PredictedJobView { Id = 10, Name = "G", PredictedJobViewCounter = 700, Date = new DateTime(2022, 05, 10) },
                        new PredictedJobView { Id = 11, Name = "H", PredictedJobViewCounter = 720, Date = new DateTime(2022, 05, 11) },
                        new PredictedJobView { Id = 12, Name = "A", PredictedJobViewCounter = 740, Date = new DateTime(2022, 05, 12) },
                        new PredictedJobView { Id = 13, Name = "G", PredictedJobViewCounter = 1000, Date = new DateTime(2022, 05, 13) },
                        new PredictedJobView { Id = 14, Name = "J", PredictedJobViewCounter = 1300, Date = new DateTime(2022, 05, 14) },
                        new PredictedJobView { Id = 15, Name = "A", PredictedJobViewCounter = 1500, Date = new DateTime(2022, 05, 15) }
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
