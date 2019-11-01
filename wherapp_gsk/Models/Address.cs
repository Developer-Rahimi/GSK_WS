using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wherapp_gsk.Models
{
    public class Addresses
    {
        public int AddressID { get; set; }
        public User user { get; set; }
        public int? UserID { get; set; }

        public string AddressName { get; set; }
        public State state  { get; set; }
        public int? StateID { get; set; }
        public City city { get; set; }
        public int? CityID { get; set; }

        public string Street { get; set; }

        public string Alley { get; set; }

        public string Plaque { get; set; }

        public decimal? LocationLatitude { get; set; }

        public decimal? LocationLongitude { get; set; }

    }

}