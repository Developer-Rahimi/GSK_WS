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
    public class AddressController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();
        public HttpResponseMessage Get()
        {
            var data = db.addresses.ToList();
            /* .Include(x => x.User)*/
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        public HttpResponseMessage Post([FromBody] Address address)
        {
            Result result = new Result();
            result.Status = "OK";
            db.addresses.Add(address);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}
