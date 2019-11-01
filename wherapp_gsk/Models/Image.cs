using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wherapp_gsk.Models
{
  
    public class Image
    {
        public int id { get; set; }
        public Content Content { get; set; }
        public long ContentID { get; set; }
        public string ImageUrl { get; set; }

        

    }
}