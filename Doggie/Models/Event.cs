using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace Doggie.Models
{
    public class Event
    {
        public int Id { get; set; }

        public string Location { get; set; }

        [Display(Name = "Dog Owner")]
        public string DogOwnerName { get; set; }

        [Display(Name = "Start Time")]
        public DateTime StartingTime { get; set; }

        [Display(Name = "Walking Time")]
        public int EstimatedTimeMinutes { get; set; }
    }
}