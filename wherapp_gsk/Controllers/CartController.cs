using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using wherapp_gsk.Models;
using wherapp_gsk.Services;
using System.Data.Entity;
namespace wherapp_gsk.Controllers
{
    public class CartController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();
        public HttpResponseMessage Get()
        {
            var Carts = db.Carts.Include(x => x.Product).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, Carts);
        }/*.Include(x => x.Carts.Select(w => w.Content.Products))*/
        public HttpResponseMessage Get(int index)
        {
           var data =db.Orders.Where(e=>e.UserID== index &e.Pay==false).Include(x => x.Carts).Include(x => x.Carts.Select(w=>w.Product)).ToList();
            /* .Include(x => x.User)*/
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        public HttpResponseMessage Post([FromBody] Cart cart)
        {
            Result result = new Result();
            var or = new Order();
            var order = db.Orders.FirstOrDefault(x=>x.UserID==cart.UserID&x.Pay==false);
            if (order == null)
            {
               
                or.UserID = cart.UserID;
                or.Pay = false;
                or.Date = DateTime.Now;
                db.Orders.Add(or);
                db.SaveChanges();
               order = db.Orders.FirstOrDefault(x => x.UserID == cart.UserID & x.Pay == false);
            }else
            {
                var temp = db.Carts.FirstOrDefault(x => x.UserID == cart.UserID & x.OrderID == order.OrderID &x.ProductID==cart.ProductID);
                if(temp == null)
                {
                    cart.OrderID = order.OrderID;
                    db.Carts.Add(cart);
                    db.SaveChanges();

                }
                else
                {
                    temp.Quantity += cart.Quantity;
                    db.SaveChanges();
                }
            }
            result.Status = "OK";
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}
