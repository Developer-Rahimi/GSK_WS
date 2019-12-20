using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using wherapp_gsk.Services;

namespace wherapp_gsk.Controllers
{
    public class CategoryController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();
        public HttpResponseMessage Get()
        {
            var category = db.Category.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, category);
        }
    }
}
