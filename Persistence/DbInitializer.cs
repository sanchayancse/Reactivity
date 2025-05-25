using System;
using Domain;

namespace Persistence;

public class DbInitializer
{
    public static async Task SeedData(AppDbContext context)
    {
        if (context.Activities.Any()) return;

        var activities = new List<Activity>
        {
            new ()
            {
                Title = "test",
                Date = DateTime.Now.AddMonths(-2),
                Description = "test",
                Category = "test",
                City = "test",
                Venue = "test",
                Latitude = 51.5072,
                Longitude = -0.1276
            },
            new ()
            {
                Title = "test2",
                Date = DateTime.Now.AddMonths(-1),
                Description = "test2",
                Category = "test2",
                City = "test2",
                Venue = "test2",
                Latitude = 51.5072,
                Longitude = -0.1276
            },
        };
        context.Activities.AddRange(activities);
        await context.SaveChangesAsync();
     }

}
