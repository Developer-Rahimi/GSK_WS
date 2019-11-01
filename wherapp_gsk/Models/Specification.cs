using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wherapp_gsk.Models
{
  
    public class Specification
    {
        public int SpecificationID { get; set; }
        public long ContentID   { get; set; }
        public List<SubSpecification> SubSpecifications { get; set; }
        public String SpecificationName { get; set; }

    }
}