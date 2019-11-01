using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wherapp_gsk.Models
{
    public class SubCategory
    {
        public int id { get; set; }
        public int CategoryID { get; set; }
        public String SubCategoryName { get; set; }
    }
}