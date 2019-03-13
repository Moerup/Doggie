using Doggie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using  System.Data.Entity;
using Doggie.ViewModels;

namespace Doggie.Controllers
{
    public class EventController : Controller
    {
        private ApplicationDbContext _context;

        public EventController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpPost]
        public ActionResult Save(Event walkEvent)
        {
            _context.Events.Add(walkEvent);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        // GET: Event
        [Authorize(Roles = "")]
        public ViewResult Index()
        {
            var locations = _context.Locations.ToList();
            var viewModel = new EventViewModel
            {
                Location = locations
            };

            return View("Index", viewModel);
        }
    }
}