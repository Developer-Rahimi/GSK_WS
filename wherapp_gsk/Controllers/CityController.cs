using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using wherapp_gsk.Models;
using wherapp_gsk.Services;

namespace wherapp_gsk.Controllers
{
    public class CityController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();
        public HttpResponseMessage Get(int index)
        {
            var data = db.States.Where(x=>x.StateID==index).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        public HttpResponseMessage Post([FromBody] City city)
        {
            Result result = new Result();
            db.Cities.Add(city);
            db.SaveChanges();
            result.Status = "OK";
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}
