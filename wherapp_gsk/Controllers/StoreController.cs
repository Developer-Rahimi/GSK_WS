﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using wherapp_gsk.Models;
using wherapp_gsk.Services;

namespace wherapp_gsk.Controllers
{
    public class StoreController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();
        public HttpResponseMessage Get()
        {
            var data = db.stores.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        public HttpResponseMessage Post([FromBody] Store store)
        {
            var sto = db.stores.FirstOrDefault(x=>x.ProductID==store.ProductID);
            Result result = new Result();
            if (sto != null)
            {
                sto.Quantity += store.Quantity;
                db.SaveChanges();
            }
            else
            {
                db.stores.Add(store);
                db.SaveChanges();
            }
           
            result.Status = "OK";
            
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}
