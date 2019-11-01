using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using wherapp_gsk.Services;

namespace wherapp_gsk.Controllers
{
    public class AddressController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();
        public HttpResponseMessage Get()
        {
            //var Carts = db.Carts.Include(x => x.Content).ToList();
            /* .Include(x => x.User)*/
            return Request.CreateResponse(HttpStatusCode.OK, "Ok");
        }
    }
}
