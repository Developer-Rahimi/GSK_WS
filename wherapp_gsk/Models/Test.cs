using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace wherapp_gsk.Models
{
   
        public class State
        {
            [Key]
            public int StateID { get; set; }
            public string StateName { get; set; }
            public List<City> City { get; set; }
            //Adding Foreign Key constraints for country  
          
        }

        public class City
        {
            [Key]
            public int CityID { get; set; }
            public string CityName { get; set; }
            //Adding Foreign Key Constraints for State  
            public int StateID { get; set; }
            public State State { get; set; }
        }
   
}