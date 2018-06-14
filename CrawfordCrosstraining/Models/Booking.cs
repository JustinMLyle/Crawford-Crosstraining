using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrawfordCrosstraining.Models
{
    public class Booking
    {

        [Key]
        int ID { get; set; }

        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }

        ApplicationUser Member { get; set; }
        ApplicationUser Trainer { get; set; }

    }
}