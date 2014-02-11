using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using BM.Web.Models;

namespace BM.Web.Controllers
{
    public class HomeController : Controller
    {
        
        BookMasterDb _db = new BookMasterDb();
        
        public ActionResult Index()
        {

            var model = _db.Items.ToList();

            ViewBag.Message = " When a Simple Search is Just not Enough!";

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var model = (from i in _db.Items where i.ItemId == id select i).Single();
            ViewBag.Message = "Edit Page";
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Us";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
