using Ef_createCrud_Ajax.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ef_createCrud_Ajax.Controllers
{
    public class HomeController : Controller
    {
        private DataContext db = new DataContext();

        public ActionResult Index()
        {
            return View();
        }
       
        public dynamic Addproduct(Products p)
        {
            db.products.Add(p);
            db.SaveChanges();

            return "ss";
        }
        public dynamic Getallproducts()
        {
            var data = db.products.ToList();
            var json = JsonConvert.SerializeObject(data);

            return json;
        }
        public dynamic Removedata(int id)
        {
            var data = db.products.Find(id);
            db.products.Remove(data);
            db.SaveChanges();
            return "success";
        }
        public dynamic EditData(int id)
        {
            var data = db.products.Find(id);
            var json = JsonConvert.SerializeObject(data);
            return json;
        }
        public dynamic Updatedata(Products p)
        {
            var data = db.products.Find(p.ProductId);
            data.Firstname = p.Firstname;
            data.Lastname = p.Lastname;
            data.Email = p.Email;
            db.Entry(data).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return "succes";

        }
    }
}
