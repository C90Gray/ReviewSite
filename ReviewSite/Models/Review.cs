using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReviewSite.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        
        public string Name { get; set; }
        public string Comment { get; set; }
        public DateTime PublishDate { get; set; }
        [Range(0,5)]
        public int Rating { get; set; }
        public bool WouldReccomend { get; set; }

        [ForeignKey("Category"), Display(Name = "Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }


    }
}