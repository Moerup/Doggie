using Doggie.Models;

namespace Doggie.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Doggie.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Doggie.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Events.AddOrUpdate(
    e => e.Id,
                new Event { Id = 1, DogOwnerName = "Michael", EstimatedTimeMinutes = 30, LocationId = 2, StartingTime = TimeSpan.Parse("12:20"), Date = DateTime.Today, Comment = "This is a comment.",  },
                new Event { Id = 2, DogOwnerName = "Louise", EstimatedTimeMinutes = 20, LocationId = 1, StartingTime = TimeSpan.Parse("12:30"), Date = DateTime.Today, Comment = "This is a comment." },
                new Event { Id = 3, DogOwnerName = "Nikolaj", EstimatedTimeMinutes = 45, LocationId = 4, StartingTime = TimeSpan.Parse("12:40"), Date = DateTime.Today, Comment = "This is a comment." },
                new Event { Id = 4, DogOwnerName = "Mathias", EstimatedTimeMinutes = 100, LocationId = 5, StartingTime = TimeSpan.Parse("14:20"), Date = DateTime.Today, Comment = "This is a comment." },
                new Event { Id = 5, DogOwnerName = "Rasmus", EstimatedTimeMinutes = 15, LocationId = 2, StartingTime = TimeSpan.Parse("15:20"), Date = DateTime.Today, Comment = "This is a comment." },
                new Event { Id = 6, DogOwnerName = "Helle", EstimatedTimeMinutes = 10, LocationId = 3, StartingTime = TimeSpan.Parse("16:20"), Date = DateTime.Today, Comment = "This is a comment." },
                new Event { Id = 7, DogOwnerName = "Magnus", EstimatedTimeMinutes = 15, LocationId = 4, StartingTime = TimeSpan.Parse("17:10"), Date = DateTime.Today, Comment = "This is a comment." },
                new Event { Id = 8, DogOwnerName = "Palle", EstimatedTimeMinutes = 30, LocationId = 1, StartingTime = TimeSpan.Parse("17:50"), Date = DateTime.Today, Comment = "This is a comment." },
                new Event { Id = 9, DogOwnerName = "Palle", EstimatedTimeMinutes = 30, LocationId = 2, StartingTime = TimeSpan.Parse("18:02"), Date = DateTime.Today, Comment = "This is a comment." },
                new Event { Id = 10, DogOwnerName = "Palle", EstimatedTimeMinutes = 30, LocationId = 6, StartingTime = TimeSpan.Parse("18:20"), Date = DateTime.Today, Comment = "This is a comment." },
                new Event { Id = 11, DogOwnerName = "Palle", EstimatedTimeMinutes = 30, LocationId = 5, StartingTime = TimeSpan.Parse("19:20"), Date = DateTime.Today, Comment = "This is a comment." },
                new Event { Id = 12, DogOwnerName = "Palle", EstimatedTimeMinutes = 30, LocationId = 3, StartingTime = TimeSpan.Parse("20:30"), Date = DateTime.Today, Comment = "This is a comment." }
                    );
        }
    }
}