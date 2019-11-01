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
    public class TagController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();
        public HttpResponseMessage Get()
        {
            var tags = db.Tags.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, tags);
        }
        public HttpResponseMessage Post([FromBody] Tag tag)
        {
            Result result = new Result();
            try
            {
               
                db.Tags.Add(tag);
                db.SaveChanges();
                result.Status = "OK";
            }
            catch (Exception e)
            {
                result.Status = "Error:" + e.Message;
            }

            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}
