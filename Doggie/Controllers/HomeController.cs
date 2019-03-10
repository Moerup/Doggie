using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Doggie.Models;

namespace Doggie.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var events = GetEvents();
            return View(events);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Doggie is a page to connect people talking a walk in one of the forests in Odense";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact for support";

            return View();
        }
        private IEnumerable<Event> GetEvents()
        {
            return new List<Event>
            {
                new Event {Id = 1, DogOwnerName = "Michael", EstimatedTimeMinutes = 30, Location = "Bøgeskoven", StartingTime = DateTime.Now.AddMinutes(5)},
                new Event {Id = 2, DogOwnerName = "Louise", EstimatedTimeMinutes = 20, Location = "Hundeparken", StartingTime = DateTime.Now.AddMinutes(10)},
                new Event {Id = 3, DogOwnerName = "Nikolaj", EstimatedTimeMinutes = 45, Location = "Egeskoven", StartingTime = DateTime.Now.AddMinutes(15)},
                new Event {Id = 4, DogOwnerName = "Mathias", EstimatedTimeMinutes = 100, Location = "Sankt Williams", StartingTime = DateTime.Now.AddMinutes(20)},
                new Event {Id = 5, DogOwnerName = "Rasmus", EstimatedTimeMinutes = 15, Location = "DoggoPlay", StartingTime = DateTime.Now.AddMinutes(25)},
                new Event {Id = 6, DogOwnerName = "Helle", EstimatedTimeMinutes = 10, Location = "Odense Skov", StartingTime = DateTime.Now.AddMinutes(30)},
                new Event {Id = 7, DogOwnerName = "Magnus", EstimatedTimeMinutes = 15, Location = "Kongens have", StartingTime = DateTime.Now.AddMinutes(35)},
                new Event {Id = 8, DogOwnerName = "Palle", EstimatedTimeMinutes = 30, Location = "Dronningens have", StartingTime = DateTime.Now.AddMinutes(40)},
                new Event {Id = 9, DogOwnerName = "Palle", EstimatedTimeMinutes = 30, Location = "Dronningens have", StartingTime = DateTime.Now.AddMinutes(40)},
                new Event {Id = 10, DogOwnerName = "Palle", EstimatedTimeMinutes = 30, Location = "Dronningens have", StartingTime = DateTime.Now.AddMinutes(40)},
                new Event {Id = 11, DogOwnerName = "Palle", EstimatedTimeMinutes = 30, Location = "Dronningens have", StartingTime = DateTime.Now.AddMinutes(40)},
                new Event {Id = 12, DogOwnerName = "Palle", EstimatedTimeMinutes = 30, Location = "Dronningens have", StartingTime = DateTime.Now.AddMinutes(40)},
            };
        }

        public PartialViewResult EventInformationPartialViewResult()
        {
            return PartialView("_EventInformation");
        }
    }
}