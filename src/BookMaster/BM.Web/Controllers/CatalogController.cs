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

    }
}
