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
    public class SpecificationController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();
        public HttpResponseMessage Get()
        {
            //var db = new ApplicationDBContext();
            var Contents = db.Specifications.Include(x => x.SubSpecifications).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, Contents);
        }
        public HttpResponseMessage Post([FromBody] Specification specification)
        {
            Result result = new Result();
            try
            {

                db.Specifications.Add(specification);
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
