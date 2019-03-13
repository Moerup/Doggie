using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Doggie.Models;

namespace Doggie.ViewModels
{
    public class EventViewModel
    {
        public IEnumerable<Location> Location { get; set; }
        public Event Event { get; set; }
    }
}