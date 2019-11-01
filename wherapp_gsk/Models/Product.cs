using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wherapp_gsk.Models
{
  
    public class Product
    {
        public int id { get; set; }
        public Content Content { get; set; }
        public long ContentID { get; set; }
        public Category Category { get; set; }
        public int CategoryID { get; set; }
        public int? SubCategoryID { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductPriceUnit { get; set; }
        public int ProductReview { get; set; }

    }
}