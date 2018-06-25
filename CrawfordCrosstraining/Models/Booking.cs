using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using DHTMLX.Scheduler;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrawfordCrosstraining.Models
{
    public class Booking
    {

        

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DHXJson(Alias = "id")]
        public int Id { get; set; }

        [DHXJson(Alias = "text")]
        public string Description { get; set; }

        [DHXJson(Alias = "start_date")]
        public DateTime StartDate { get; set; }

        [DHXJson(Alias = "end_date")]
        public DateTime EndDate { get; set; }

    }
}