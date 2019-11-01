using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using wherapp_gsk.Models;
using wherapp_gsk.Services;
using System.IO;
using System.Net.Http.Headers;
using System.Web;

namespace wherapp_gsk.Controllers
{
    public class ImageController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();
        public HttpResponseMessage Get()
        {
            var data = db.Images.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        public HttpResponseMessage Post([FromBody] Image image)
        {
            Result result = new Result();
            try
            {
                image.ImageUrl = image.ImageUrl.Replace("gsk/Appdata/images/", "");
                db.Images.Add(image);
                db.SaveChanges();
                result.Status = "OK";
            }
            catch(Exception ex)
            {
                result.Status = "Error:"+ ex.Message;
            }

            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
        public static int RandomNumber(int min, int max)
        {
            var rand = new Random();
            return rand.Next(min, max);
        }

    }
}
