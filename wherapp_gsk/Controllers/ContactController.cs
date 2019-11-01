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
    public class ContactController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();
        public HttpResponseMessage Get()
        {
            var Contacts = db.contacts.ToList();

            return Request.CreateResponse(HttpStatusCode.OK, Contacts);
        }
        public HttpResponseMessage Post([FromBody] Contact contact)
        {
            Result result = new Result();
            try
            {
                contact.ContactDate = DateTime.Now;
                db.contacts.Add(contact);
                db.SaveChanges();
                result.Status = "OK";
            }
            catch (Exception ex)
            {
                result.Status = "Error:"+ex.Message;
            }

            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}
