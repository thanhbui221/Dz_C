using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Dz2.DAL;
using Dz2.Models;

namespace Dz2.Controllers
{
    public class CabinsController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: Cabins
        public ActionResult Index()
        {
            return View(db.Cabins.ToList());
        }

        // GET: Cabins/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cabin cabin = db.Cabins.Find(id);
            if (cabin == null)
            {
                return HttpNotFound();
            }
            return View(cabin);
        }

        // GET: Cabins/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cabins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CabinID,model_name_cabin,serial_number_cabin,type_cabin")] Cabin cabin)
        {
            if (ModelState.IsValid)
            {
                db.Cabins.Add(cabin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cabin);
        }

        // GET: Cabins/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cabin cabin = db.Cabins.Find(id);
            if (cabin == null)
            {
                return HttpNotFound();
            }
            return View(cabin);
        }

        // POST: Cabins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CabinID,model_name_cabin,serial_number_cabin,type_cabin")] Cabin cabin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cabin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cabin);
        }

        // GET: Cabins/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cabin cabin = db.Cabins.Find(id);
            if (cabin == null)
            {
                return HttpNotFound();
            }
            return View(cabin);
        }

        // POST: Cabins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cabin cabin = db.Cabins.Find(id);
            db.Cabins.Remove(cabin);
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
