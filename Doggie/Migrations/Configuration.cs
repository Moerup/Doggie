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
            ContextKey = "Doggie.Models.ApplicationDbContext";
        }

        protected override void Seed(Doggie.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Events.AddOrUpdate(
                e => e.Id,
                new Event { Id = 1, DogOwnerName = "Michael", EstimatedTimeMinutes = 30, Location = "Bøgeskoven", StartingTime = DateTime.Now.AddMinutes(5) },
                new Event { Id = 2, DogOwnerName = "Louise", EstimatedTimeMinutes = 20, Location = "Hundeparken", StartingTime = DateTime.Now.AddMinutes(10) },
                new Event { Id = 3, DogOwnerName = "Nikolaj", EstimatedTimeMinutes = 45, Location = "Egeskoven", StartingTime = DateTime.Now.AddMinutes(15) },
                new Event { Id = 4, DogOwnerName = "Mathias", EstimatedTimeMinutes = 100, Location = "Sankt Williams", StartingTime = DateTime.Now.AddMinutes(20) },
                new Event { Id = 5, DogOwnerName = "Rasmus", EstimatedTimeMinutes = 15, Location = "DoggoPlay", StartingTime = DateTime.Now.AddMinutes(25) },
                new Event { Id = 6, DogOwnerName = "Helle", EstimatedTimeMinutes = 10, Location = "Odense Skov", StartingTime = DateTime.Now.AddMinutes(30) },
                new Event { Id = 7, DogOwnerName = "Magnus", EstimatedTimeMinutes = 15, Location = "Kongens have", StartingTime = DateTime.Now.AddMinutes(35) },
                new Event { Id = 8, DogOwnerName = "Palle", EstimatedTimeMinutes = 30, Location = "Dronningens have", StartingTime = DateTime.Now.AddMinutes(40) },
                new Event { Id = 9, DogOwnerName = "Palle", EstimatedTimeMinutes = 30, Location = "Hundeparken", StartingTime = DateTime.Now.AddMinutes(40) },
                new Event { Id = 10, DogOwnerName = "Palle", EstimatedTimeMinutes = 30, Location = "Dronningens have", StartingTime = DateTime.Now.AddMinutes(40) },
                new Event { Id = 11, DogOwnerName = "Palle", EstimatedTimeMinutes = 30, Location = "Bøgeskoven", StartingTime = DateTime.Now.AddMinutes(40) },
                new Event { Id = 12, DogOwnerName = "Palle", EstimatedTimeMinutes = 30, Location = "Egeskoven", StartingTime = DateTime.Now.AddMinutes(40) }
                );
        }
    }
}
