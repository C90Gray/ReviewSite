using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReviewSite.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        public string Type { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

    }
}