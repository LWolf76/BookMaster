using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookMaster.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "What is this all about?";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Find Us on GitHub.";

            return View();
        }
    }
}