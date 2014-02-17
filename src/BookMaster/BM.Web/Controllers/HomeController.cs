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

        public ActionResult Index(String searchTerm = "")
        {
            var items = _db.Items.ToList();

            var model = from i in items
                .Where(i => i.Title.Contains(searchTerm) || i.Author.Contains(searchTerm))
                        select i;


            ViewBag.Message = " When a Simple Search is Just not Enough!";

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
