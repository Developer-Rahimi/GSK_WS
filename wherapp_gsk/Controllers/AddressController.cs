using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Data.Entity;
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
            var data = db.addresses.Include(x => x.User).Include(x => x.State).Include(x => x.City).ToList();
            /* */
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        public HttpResponseMessage Get(int UserID)
        {
            var data = db.addresses.Include(x => x.User).Include(x => x.State).Include(x => x.City).Where(x=>x.UserID== UserID).ToList();
            /* */
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
