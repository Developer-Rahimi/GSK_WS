using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Data.Entity;
using System.Net.Http;
using System.Web.Http;
using wherapp_gsk.Services;
using wherapp_gsk.Models;

namespace wherapp_gsk.Controllers
{
    
    public class TestController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();
        /*public HttpResponseMessage Get()
        {
            //var db = new ApplicationDBContext();
            var Contents = db.Products.Include(x=>x.Category).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, Contents);
        }
        public HttpResponseMessage Put()
        {
            //var db = new ApplicationDBContext();
            //var Contents = db.Products.Include(x => x.Category).ToList();
            Result result = new Result();
            result.Status = "OK";
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }*/
    }
}
