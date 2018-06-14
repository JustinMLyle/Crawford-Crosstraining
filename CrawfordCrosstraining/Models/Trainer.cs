using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrawfordCrosstraining.Models
{
    public class Trainer
    {
       ApplicationUser TrainerUser { get; set; }       
       List<ApplicationUser> Clients { get; set; }
          
    

    }
}