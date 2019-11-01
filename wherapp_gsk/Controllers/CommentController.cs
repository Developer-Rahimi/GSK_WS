using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using wherapp_gsk.Services;
using wherapp_gsk.Models;

namespace wherapp_gsk.Controllers
{
    public class CommentController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();
        public HttpResponseMessage Get()
        {
            //var db = new ApplicationDBContext();
            var Contents = db.Comments.Include(x => x.User).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, Contents);
        }
        public HttpResponseMessage Post([FromBody] Comment comment)
        {
            Result result = new Result();
            try
            {
            db.Comments.Add(comment);
            DateTime dt = DateTime.Now;
            comment.CommentCreateAt =dt;
            db.SaveChanges();
                result.Status = "OK";
            }
            catch(Exception ex)
            {
                result.Status = "Error:"+ex.Message;
            }
            
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
        public HttpResponseMessage Put([FromBody] Comment comment ,int index)
        {
            var comm = db.Comments.FirstOrDefault(x => x.id == index);
            comm.CommentRating = comment.CommentRating;
            comm.CommentSubject = comment.CommentSubject;
            DateTime dt = DateTime.Now;
            comment.CommentCreateAt = dt;
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, comment);
        }

    }
}
