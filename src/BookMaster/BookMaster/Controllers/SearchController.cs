using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using BookMaster.Models;
using BookMaster.DAL;
using PagedList;

namespace BookMaster.Controllers
{
    public class SearchController : Controller
    {
        private BookMasterContext db = new BookMasterContext();

        // GET: /Search/
        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.TitleSortParm = String.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
            ViewBag.AuthorSortParm = sortOrder == "Author" ? "Author_desc" : "Author";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var items = from i in db.Items
                        select i;

            if (!String.IsNullOrEmpty(searchString))
            {
                items = items.Where(i => i.Author.ToUpper().Contains(searchString.ToUpper()) || i.Title.ToUpper().Contains(searchString.ToUpper()));
            }

            switch (sortOrder)
            {
                case "title_desc":
                    items = items.OrderByDescending(i => i.Title);
                    break;
                case "Author":
                    items = items.OrderBy(i => i.Location);
                    break;
                case "Author_desc":
                    items = items.OrderByDescending(i => i.Location);
                    break;
                default:
                    items = items.OrderBy(i => i.Title);
                    break;
            }

            int pageSize = 3;
            int pageNumber = (page ?? 1);

            return View(items.ToPagedList(pageNumber, pageSize));
        }

        // GET: /Search/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // GET: /Search/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Search/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ItemId,Type,Title,Author,PersonalAuthor,ISBN,Publisher,Published,Edition,PublicationInformation,Pages,Location,Summary")] Item item)
        {
            if (ModelState.IsValid)
            {
                db.Items.Add(item);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(item);
        }

        // GET: /Search/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: /Search/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ItemId,Type,Title,Author,PersonalAuthor,ISBN,Publisher,Published,Edition,PublicationInformation,Pages,Location,Summary")] Item item)
        {
            if (ModelState.IsValid)
            {
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(item);
        }

        // GET: /Search/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: /Search/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Item item = db.Items.Find(id);
            db.Items.Remove(item);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
