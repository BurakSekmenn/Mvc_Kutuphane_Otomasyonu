using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Mvc_Kutuphane_Otomasyonu.Entities.Model;
using Mvc_Kutuphane_Otomasyonu.Entities.Model.Context;

namespace Mvc_Kutuphane_Otomasyonu.Controllers
{
    public class DuyrularController : Controller
    {
        private KutuphaneContext db = new KutuphaneContext();

        // GET: Duyrular
        public ActionResult Index()
        {
            return View(db.Duyrulars.ToList());
        }

        // GET: Duyrular/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Duyrular duyrular = db.Duyrulars.Find(id);
            if (duyrular == null)
            {
                return HttpNotFound();
            }
            return View(duyrular);
        }

        // GET: Duyrular/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Duyrular/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Baslik,Duyuru,Acıklama,Tarih")] Duyrular duyrular)
        {
            if (ModelState.IsValid)
            {
                db.Duyrulars.Add(duyrular);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(duyrular);
        }

        // GET: Duyrular/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Duyrular duyrular = db.Duyrulars.Find(id);
            if (duyrular == null)
            {
                return HttpNotFound();
            }
            return View(duyrular);
        }

        // POST: Duyrular/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Baslik,Duyuru,Acıklama,Tarih")] Duyrular duyrular)
        {
            if (ModelState.IsValid)
            {
                db.Entry(duyrular).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(duyrular);
        }

        // GET: Duyrular/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Duyrular duyrular = db.Duyrulars.Find(id);
            if (duyrular == null)
            {
                return HttpNotFound();
            }
            return View(duyrular);
        }

        // POST: Duyrular/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Duyrular duyrular = db.Duyrulars.Find(id);
            db.Duyrulars.Remove(duyrular);
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
