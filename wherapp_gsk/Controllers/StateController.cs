﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Data.Entity;
using System.Net.Http;
using System.Web.Http;
using wherapp_gsk.Services;

namespace wherapp_gsk.Controllers
{
    public class StateController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();
        public HttpResponseMessage Get()
        {
            var data = db.States.Include(e=>e.City).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
