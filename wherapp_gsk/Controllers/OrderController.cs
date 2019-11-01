using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using wherapp_gsk.Services;
using System.Data.Entity;
using wherapp_gsk.Models;

namespace wherapp_gsk.Controllers
{
    public class OrderController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();
        public HttpResponseMessage Get()
        {
            var Orders = db.Orders.Where(x=>x.Pay==true).Include(x => x.Carts).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, Orders);
        }
        public HttpResponseMessage Get(int index)
        {
            var Orders = db.Orders.Where(x => x.Pay == true &x.UserID== index).Include(x => x.Carts).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, Orders);
        }
        public HttpResponseMessage Post([FromBody] Order order)
        {
            Result result = new Result();

            try
            {
                var ord=db.Orders.FirstOrDefault(e => e.OrderID == order.OrderID);
                ord.DatePay = DateTime.Now;
                ord.OrderCode = order.OrderCode;
                ord.Pay = true;
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
