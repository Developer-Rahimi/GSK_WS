using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wherapp_gsk.Models
{
  
    public class Introduction
    {
        public int id { get; set; }
        public int UserID { get; set; }
        public long ContentID { get; set; }
        public String IntroductionTitle { get; set; }
        public String IntroductionDesc { get; set; }
    }
}