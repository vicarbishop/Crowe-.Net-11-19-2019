using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CHWebAPI.Controllers
{
    public class EventsController : Controller
    {
        private EventEntities db = new EventEntities();

        //
        // GET: /Events/

        public ActionResult Index()
        {
            return View(db.Events.ToList());
        }

        //
        // GET: /Events/Details/5

        public ActionResult Details(int id = 0)
        {
            Event evt = db.Events.Find(id);
            if (evt == null)
            {
                return HttpNotFound();
            }
            return View(evt);
        }

        //
        // GET: /Events/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Events/Create

        [HttpPost]
        public ActionResult Create(Event evt)
        {
            if (ModelState.IsValid)
            {
                db.Events.Add(evt);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(evt);
        }

        //
        // GET: /Events/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Event evt = db.Events.Find(id);
            if (evt == null)
            {
                return HttpNotFound();
            }
            return View(evt);
        }

        //
        // POST: /Events/Edit/5

        [HttpPost]
        public ActionResult Edit(Event evt)
        {
            if (ModelState.IsValid)
            {
                db.Entry(evt).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(evt);
        }

        //
        // GET: /Events/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Event evt = db.Events.Find(id);
            if (evt == null)
            {
                return HttpNotFound();
            }
            return View(evt);
        }

        //
        // POST: /Events/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Event evt = db.Events.Find(id);
            db.Events.Remove(evt);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}