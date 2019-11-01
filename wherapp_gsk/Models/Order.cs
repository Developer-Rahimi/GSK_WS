using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wherapp_gsk.Models
{
  
    public class Order
    {
        public ICollection<Cart> Carts { get; set; }
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public string OrderCode { get; set; }
        public bool Pay { get; set; }
        public DateTime Date { get; set; }
        public DateTime? DatePay { get; set; }
    }
}