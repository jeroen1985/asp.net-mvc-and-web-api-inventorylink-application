using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using InventoryLink2.Models;
using System.Data.Entity.Infrastructure;

namespace InventoryLink2.Controllers
{
    [Authorize(Roles = "Admin")]
    public class LocationsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Locations
        public ActionResult Index()
        {
            return View(db.Locations.ToList());
        }

        // GET: Locations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Location location = db.Locations.Find(id);
            if (location == null)
            {
                return HttpNotFound();
            }
            return View(location);
        }

        // GET: Locations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Locations/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name")] Location location)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Locations.Add(location);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (DbUpdateException)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
            }

            return View(location);
        }

        // POST [jQuery Example]: Locations/Create 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult CreateAjax([Bind(Include = "Name")] Location location)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Locations.Add(location);
                    db.SaveChanges();
                    return Json("Succes! Please add another locations!");
                }
                catch (DbUpdateException)
                {
                    return Json("Invalid Model");
                }
            }
            return Json("Invalid Model");
        }

        // GET: Locations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Location location = db.Locations.Find(id);
            if (location == null)
            {
                return HttpNotFound();
            }
            return View(location);
        }

        // POST: Locations/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LocationId,Name")] Location location)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Entry(location).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (DbUpdateException)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
            }
            return View(location);
        }

        // GET: Locations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Location location = db.Locations.Find(id);
            if (location == null)
            {
                return HttpNotFound();
            }
            return View(location);
        }

        // POST: Locations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Location location = db.Locations.Find(id);
            db.Locations.Remove(location);
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
