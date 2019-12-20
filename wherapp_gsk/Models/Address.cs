using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wherapp_gsk.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        public User User { get; set; }
        public int? UserID { get; set; }

        public string AddressName { get; set; }
        public State State  { get; set; }
        public int? StateID { get; set; }
        public City City { get; set; }
        public int? CityID { get; set; }

        public string Street { get; set; }

        public string Alley { get; set; }

        public string Plaque { get; set; }

        public decimal? LocationLatitude { get; set; }

        public decimal? LocationLongitude { get; set; }

    }

}