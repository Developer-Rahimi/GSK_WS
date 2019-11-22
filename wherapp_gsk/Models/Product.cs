using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wherapp_gsk.Models
{
  
    public class Product
    {
        public int id { get; set; }

        public string ProductName { get; set; }

        public long ContentID { get; set; }
        public virtual Category Category { get; set; }
        public int? CategoryID { get; set; }

        public decimal? ProductPrice { get; set; }

    }
}