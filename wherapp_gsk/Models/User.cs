using System;
using System.Collections.Generic;

namespace wherapp_gsk.Models
{
    public class User
    {
        public int id { get; set; }

        /*public virtual IEnumerable<Content> Content { get; set; }*/
        public string UserName { get; set; }

        public string UserPhone { get; set; }

        public string UserEmail { get; set; }

        public string UserCode { get; set; }

        public string UserPassword { get; set; }

        public DateTime? UserDateBorn { get; set; }

        public string UserDateEn { get; set; }
        public virtual Permission Permission { get; set; }
        public int? PermissionID { get; set; }

        public int? UserCountry { get; set; }
        public virtual State State { get; set; }
        public int? StateID { get; set; }
        

        public bool? UserConfirm { get; set; }

    }

}