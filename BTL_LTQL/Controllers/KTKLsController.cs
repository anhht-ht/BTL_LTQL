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
    public class KTKLsController : Controller
    {
        private DBConnect db = new DBConnect();

        // GET: KTKLs
        public ActionResult Index()
        {
            if (Session["idAccount"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            return View(db.ktkls.ToList());
        }

        // GET: KTKLs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KTKL kTKL = db.ktkls.Find(id);
            if (kTKL == null)
            {
                return HttpNotFound();
            }
            return View(kTKL);
        }

        // GET: KTKLs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KTKLs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Ma_nv,Ktkl,Lydo")] KTKL kTKL)
        {
            if (ModelState.IsValid)
            {
                db.ktkls.Add(kTKL);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kTKL);
        }

        // GET: KTKLs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KTKL kTKL = db.ktkls.Find(id);
            if (kTKL == null)
            {
                return HttpNotFound();
            }
            return View(kTKL);
        }

        // POST: KTKLs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Ma_nv,Ktkl,Lydo")] KTKL kTKL)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kTKL).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kTKL);
        }

        // GET: KTKLs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KTKL kTKL = db.ktkls.Find(id);
            if (kTKL == null)
            {
                return HttpNotFound();
            }
            return View(kTKL);
        }

        // POST: KTKLs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            KTKL kTKL = db.ktkls.Find(id);
            db.ktkls.Remove(kTKL);
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
