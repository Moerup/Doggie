using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace Doggie.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string DogOwnerName { get; set; }
        public DateTime StartingTime { get; set; }
        public int EstimatedTimeMinutes { get; set; }

    }
}