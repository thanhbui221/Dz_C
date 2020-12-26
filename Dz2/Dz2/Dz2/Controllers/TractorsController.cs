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
    public class TractorsController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: Tractors
        public ActionResult Index()
        {
            return View(db.Tractors.ToList());
        }

        // GET: Tractors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tractor tractor = db.Tractors.Find(id);
            if (tractor == null)
            {
                return HttpNotFound();
            }
            return View(tractor);
        }

        // GET: Tractors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tractors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TractorID,model_name_tractor,serial_number_tractor")] Tractor tractor)
        {
            if (ModelState.IsValid)
            {
                db.Tractors.Add(tractor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tractor);
        }

        // GET: Tractors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tractor tractor = db.Tractors.Find(id);
            if (tractor == null)
            {
                return HttpNotFound();
            }
            return View(tractor);
        }

        // POST: Tractors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TractorID,model_name_tractor,serial_number_tractor")] Tractor tractor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tractor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tractor);
        }

        // GET: Tractors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tractor tractor = db.Tractors.Find(id);
            if (tractor == null)
            {
                return HttpNotFound();
            }
            return View(tractor);
        }

        // POST: Tractors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tractor tractor = db.Tractors.Find(id);
            db.Tractors.Remove(tractor);
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
