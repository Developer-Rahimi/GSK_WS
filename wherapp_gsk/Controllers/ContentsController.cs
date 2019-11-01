using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using wherapp_gsk.Services;
using System.Web.Mvc;
using Newtonsoft.Json;
using wherapp_gsk.Models;

namespace wherapp_gsk.Controllers
{
    public class ContentsController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();
        public HttpResponseMessage Get()
        {

            var c = db.Contents.Include(x=>x.Images).Include(x => x.Products).OrderByDescending(e=>e.ContentID)
                .ToList();

            return Request.CreateResponse(HttpStatusCode.OK, c);
        }
        public HttpResponseMessage Get(long index)
        {

            var c = db.Contents.Where(e => e.ContentID == index).Include(x => x.Images)
                .Include(x => x.Products).Include(x => x.Comments).Include(x => x.Specifications).Include(x => x.Specifications.Select(w=>w.SubSpecifications))
                .Include(x => x.Tags).Include(x => x.Introductions).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, c[0]);
        }

        public HttpResponseMessage Post([FromBody] Content content )
        {
            Result result = new Result();
            content.ContentCreateAt = DateTime.Now;
            content.ContentUpdateAt = DateTime.Now;
            content.ContentStatusID = 1;
            content.ContentTypeID = 1;
            content.ContentDateFa = "";
            db.Contents.Add(content);
            db.SaveChanges();
            result.Status = "OK";
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

    }
}
