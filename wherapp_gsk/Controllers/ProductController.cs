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
    public class ProductController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();

        public HttpResponseMessage Post([FromBody] Product product)
        {
            Result result = new Result();
            try
            {
                product.ProductReview = 0;
                product.CategoryID = 1;
                db.Products.Add(product);
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
