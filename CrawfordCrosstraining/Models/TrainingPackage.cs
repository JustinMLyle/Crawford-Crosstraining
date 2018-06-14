using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CrawfordCrosstraining.Models
{
    public class TrainingPackage
    {
        [Key]
        int ID { get; set; }

        string PackageName { get; set; }
        decimal PackagePrice { get; set; }        
    }
}