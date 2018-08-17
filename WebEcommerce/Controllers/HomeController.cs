using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEcommerce.Models;

namespace WebEcommerce.Controllers
{
    public class HomeController : Controller
    {
        private CT239Entities db = new CT239Entities();
        public ActionResult Index()
        {
            var lstProduct1 = db.Products.Where(n => n.CategoryId == 1);
            ViewBag.ListProduct1 = lstProduct1;


            var lstProduct2 = db.Products.Where(n => n.CategoryId == 2);
            ViewBag.ListProduct2 = lstProduct2;
            ViewBag.Categories = db.Categories.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Category()
        {
            ViewBag.Categories = db.Categories.ToList();
            //var lstCate = from CAT in db.Categories select CAT;
            return PartialView("_CategoryPartial");
        }

        public ActionResult ProductStyle1Partial()
        {
            return PartialView();
        }
    }
}