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
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var events = _context.Events.ToList();
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

        public PartialViewResult EventInformationPartialViewResult()
        {
            return PartialView("_EventInformation");
        }
    }
}