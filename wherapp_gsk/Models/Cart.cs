using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wherapp_gsk.Models
{

    public class Cart
    {
        public int CartID { get; set; }
        public virtual Product Product { get; set; }
        public int ProductID { get; set; }

        public int UserID { get; set; }

        public int OrderID { get; set; }

        public int Quantity { get; set; }

        public decimal? Price { get; set; }

    }
}