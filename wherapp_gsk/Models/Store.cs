using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wherapp_gsk.Models
{
    public class Store
    {
        public int StoreID { get; set; }

        public int ProductID { get; set; }

        public int Quantity { get; set; }

        public int QuantityCell { get; set; }
    }
}