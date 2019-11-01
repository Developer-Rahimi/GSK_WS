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
    public class IntroductionController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();
        public HttpResponseMessage Get()
        {
            var data = db.Introductions.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        public HttpResponseMessage Post([FromBody] Introduction introduction)
        {
            Result result = new Result();
            try
            {
                db.Introductions.Add(introduction);
                db.SaveChanges();
                result.Status = "OK";
            }
            catch (Exception e)
            {
                result.Status = "Error:"+e.Message;
            }
            
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
        }
}
