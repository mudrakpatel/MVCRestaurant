using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCRestaurant.Models;

namespace MVCRestaurant.Controllers
{
    public class Menu_ListController : Controller
    {
        private MenuContext db = new MenuContext();

        // GET: Menu_List
        public ActionResult Index()
        {
            return View(db.Menu_Lists.ToList());
        }

        // GET: Menu_List/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                id = 1;
            }
            Menu_List menu_List = db.Menu_Lists.Find(id);
            if (menu_List == null)
            {
                return HttpNotFound();
            }
            return View(menu_List);
        }

        // GET: Menu_List/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Menu_List/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ItemId,ItemPrice,ShortDescription,LongDescription,IconImage,ItemName")] Menu_List menu_List)
        {
            if (ModelState.IsValid)
            {
                db.Menu_Lists.Add(menu_List);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(menu_List);
        }

        // GET: Menu_List/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Menu_List menu_List = db.Menu_Lists.Find(id);
            if (menu_List == null)
            {
                return HttpNotFound();
            }
            return View(menu_List);
        }

        // POST: Menu_List/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ItemId,ItemPrice,ShortDescription,LongDescription,IconImage,ItemName")] Menu_List menu_List)
        {
            if (ModelState.IsValid)
            {
                db.Entry(menu_List).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(menu_List);
        }

        // GET: Menu_List/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Menu_List menu_List = db.Menu_Lists.Find(id);
            if (menu_List == null)
            {
                return HttpNotFound();
            }
            return View(menu_List);
        }

        // POST: Menu_List/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Menu_List menu_List = db.Menu_Lists.Find(id);
            db.Menu_Lists.Remove(menu_List);
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
