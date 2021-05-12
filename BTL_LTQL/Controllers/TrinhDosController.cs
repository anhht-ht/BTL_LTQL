using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BTL_LTQL.Models;

namespace BTL_LTQL.Controllers
{
    public class TrinhDosController : Controller
    {
        private DBConnect db = new DBConnect();

        // GET: TrinhDos
        public ActionResult Index()
        {
            if (Session["idAccount"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            return View(db.Trinhdos.ToList());
        }

        // GET: TrinhDos/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrinhDo trinhDo = db.Trinhdos.Find(id);
            if (trinhDo == null)
            {
                return HttpNotFound();
            }
            return View(trinhDo);
        }

        // GET: TrinhDos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TrinhDos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Ma_trinhdo,Ten_trinhdo")] TrinhDo trinhDo)
        {
            if (ModelState.IsValid)
            {
                db.Trinhdos.Add(trinhDo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(trinhDo);
        }

        // GET: TrinhDos/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrinhDo trinhDo = db.Trinhdos.Find(id);
            if (trinhDo == null)
            {
                return HttpNotFound();
            }
            return View(trinhDo);
        }

        // POST: TrinhDos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Ma_trinhdo,Ten_trinhdo")] TrinhDo trinhDo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trinhDo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trinhDo);
        }

        // GET: TrinhDos/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrinhDo trinhDo = db.Trinhdos.Find(id);
            if (trinhDo == null)
            {
                return HttpNotFound();
            }
            return View(trinhDo);
        }

        // POST: TrinhDos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TrinhDo trinhDo = db.Trinhdos.Find(id);
            db.Trinhdos.Remove(trinhDo);
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
