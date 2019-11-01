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
    public class EmailController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();
        //[Route("Email/Check/{email:String}")]
        [HttpGet]
        public HttpResponseMessage Get(string email)
        {
            Result result = new Result();
            var user = db.User.FirstOrDefault(e=>e.UserEmail==email);
            if (user == null)
            {
                result.Status = "OK";
            }else
            {
                result.Status = "Error";
            }
            //var db = new ApplicationDBContext();
           
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}
