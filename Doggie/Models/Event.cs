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

        public Location Location { get; set; }

        public int LocationId { get; set; }

        [Required]
        [Display(Name = "Dog Owner")]
        public string DogOwnerName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Start Time")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public TimeSpan StartingTime { get; set; }

        [Required]
        [Display(Name = "Walking Time")]
        public int EstimatedTimeMinutes { get; set; }

        [DataType(DataType.MultilineText)]
        public string Comment { get; set; }
    }
}