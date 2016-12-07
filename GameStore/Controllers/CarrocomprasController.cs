using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GameStore.DAL;
using GameStore.Models;

namespace GameStore.Controllers
{
    public class CarrocomprasController : Controller
    {
        private GameContext db = new GameContext();

        // GET: Carrocompras
        public ActionResult Index()
        {
            return View(db.Carrocompras.ToList());
        }

        // GET: Carrocompras/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Carrocompras carrocompras = db.Carrocompras.Find(id);
            if (carrocompras == null)
            {
                return HttpNotFound();
            }
            return View(carrocompras);
        }

        // GET: Carrocompras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Carrocompras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id")] Carrocompras carrocompras)
        {
            if (ModelState.IsValid)
            {
                db.Carrocompras.Add(carrocompras);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(carrocompras);
        }

        // GET: Carrocompras/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Carrocompras carrocompras = db.Carrocompras.Find(id);
            if (carrocompras == null)
            {
                return HttpNotFound();
            }
            return View(carrocompras);
        }

        // POST: Carrocompras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id")] Carrocompras carrocompras)
        {
            if (ModelState.IsValid)
            {
                db.Entry(carrocompras).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(carrocompras);
        }

        // GET: Carrocompras/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Carrocompras carrocompras = db.Carrocompras.Find(id);
            if (carrocompras == null)
            {
                return HttpNotFound();
            }
            return View(carrocompras);
        }

        // POST: Carrocompras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Carrocompras carrocompras = db.Carrocompras.Find(id);
            db.Carrocompras.Remove(carrocompras);
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
