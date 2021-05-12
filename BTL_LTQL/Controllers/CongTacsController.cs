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
    public class CongTacsController : Controller
    {
        private DBConnect db = new DBConnect();

        // GET: CongTacs
        public ActionResult Index()
        {
            if (Session["idAccount"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            return View(db.Congtacs.ToList());
        }

        // GET: CongTacs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CongTac congTac = db.Congtacs.Find(id);
            if (congTac == null)
            {
                return HttpNotFound();
            }
            return View(congTac);
        }

        // GET: CongTacs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CongTacs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Ma_nv,Congviec,Ngaybatdau,Ngayketthuc,Noilamviec")] CongTac congTac)
        {
            if (ModelState.IsValid)
            {
                db.Congtacs.Add(congTac);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(congTac);
        }

        // GET: CongTacs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CongTac congTac = db.Congtacs.Find(id);
            if (congTac == null)
            {
                return HttpNotFound();
            }
            return View(congTac);
        }

        // POST: CongTacs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Ma_nv,Congviec,Ngaybatdau,Ngayketthuc,Noilamviec")] CongTac congTac)
        {
            if (ModelState.IsValid)
            {
                db.Entry(congTac).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(congTac);
        }

        // GET: CongTacs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CongTac congTac = db.Congtacs.Find(id);
            if (congTac == null)
            {
                return HttpNotFound();
            }
            return View(congTac);
        }

        // POST: CongTacs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CongTac congTac = db.Congtacs.Find(id);
            db.Congtacs.Remove(congTac);
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
