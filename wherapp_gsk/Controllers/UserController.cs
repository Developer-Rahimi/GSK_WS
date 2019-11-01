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
    public class UserController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();
       
        public HttpResponseMessage Get()
        {
            var Users = db.User.ToList();

            return Request.CreateResponse(HttpStatusCode.OK, Users);
        }
       
        public HttpResponseMessage Get(int index)
        {
            var User = db.User.FirstOrDefault(e=>e.id==index);

            return Request.CreateResponse(HttpStatusCode.OK, User);
        }
       /* public HttpResponseMessage Post([FromBody] User user)
        {
            Result result = new Result();
            try
            {
                db.User.Add(user);
                db.SaveChanges();
                result.Status = "OK";
            }catch(Exception e)
            {
                result.Status = "Error:"+e.Message;
            }
           

            return Request.CreateResponse(HttpStatusCode.OK, result);
        }*/
        [Route("User/Login")]
        [HttpPost]
        public HttpResponseMessage Login([FromBody] User user)
        {
            Result result = new Result();
            try
            {
                var data = db.User.FirstOrDefault(e => e.UserEmail.Equals(user.UserEmail)&e.UserPassword.Equals(user.UserPassword));
                if (data != null)
                {
                    result.Status = "OK";
                    result.ID = data.id;
                }
                else
                {
                    result.Status = "NO";
                }
            }
            catch (Exception e)
            {
                result.Status = "Error:" + e.Message;
            }


            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
        [Route("User/Register")]
        [HttpPost]
        public HttpResponseMessage Register([FromBody] User user)
        {

            Result result = new Result();
            db.User.Add(user);
            user.UserDateBorn = DateTime.Now;
          
            user.UserConfirm = true;
            db.SaveChanges();
            result.Status = "OK";
            /*try
            {
                
            }
            catch (Exception e)
            {
                result.Status = "Error:" + e.Message;
            }*/


            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
        [Route("User/Email/Check")]
        [HttpPost]
        public HttpResponseMessage EmailCheck([FromBody] User user)
        {
            Result result = new Result();
            try
            {
                var data = db.User.FirstOrDefault(e => e.UserEmail.Equals(user.UserEmail));
                if (data != null)
                {
                    result.Status = "OK";
                }
                else
                {
                    result.Status = "NO";
                }
            }
            catch (Exception e)
            {
                result.Status = "Error:" + e.Message;
            }


            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}
