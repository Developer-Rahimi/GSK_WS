using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wherapp_gsk.Models
{
    public class Tag
    {
        public int TagID { get; set; }
        public Content Content { get; set; }
        public long ContentID { get; set; }
        public String TagName { get; set; }
    }
}