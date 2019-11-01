using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wherapp_gsk.Models
{
  
    public class SubSpecification
    {
        public int SubSpecificationID { get; set; }
        public Specification Specification { get; set; }
        public int SpecificationID { get; set; }
        public string SubSpecificationName { get; set; }
       public string SubSpecificationDesc { get; set; }
    }
}