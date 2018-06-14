using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CrawfordCrosstraining.Models
{
    public class Trainer
    {
        [Key]
        public int Id { get; set; }

        ApplicationUser TrainerUser { get; set; }       
        List<ApplicationUser> Clients { get; set; }
          
    

    }
}