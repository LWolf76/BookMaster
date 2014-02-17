using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BM.Web.Models;

namespace BM.Web.Controllers
{
    public class CatalogController : Controller
    {
        //
        // GET: /Catalog/

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
    }
}
