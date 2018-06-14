using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrawfordCrosstraining.Models
{
    public class Payment
    {
        [Key]
        int ID { get; set; }
        decimal PaymentValue { get; set; }
        ApplicationUser Member { get; set; }
        
    }
}