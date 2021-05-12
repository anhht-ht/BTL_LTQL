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
    public class HopDongsController : Controller
    {
        private DBConnect db = new DBConnect();

        // GET: HopDongs
        public ActionResult Index()
        {
            if (Session["idAccount"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            return View(db.Hopdongs.ToList());
        }

        // GET: HopDongs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HopDong hopDong = db.Hopdongs.Find(id);
            if (hopDong == null)
            {
                return HttpNotFound();
            }
            return View(hopDong);
        }

        // GET: HopDongs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HopDongs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Ma_hd,Ma_nv,Ten_nv,Ngayky_hd,Han_hd")] HopDong hopDong)
        {
            if (ModelState.IsValid)
            {
                db.Hopdongs.Add(hopDong);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hopDong);
        }

        // GET: HopDongs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HopDong hopDong = db.Hopdongs.Find(id);
            if (hopDong == null)
            {
                return HttpNotFound();
            }
            return View(hopDong);
        }

        // POST: HopDongs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Ma_hd,Ma_nv,Ten_nv,Ngayky_hd,Han_hd")] HopDong hopDong)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hopDong).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hopDong);
        }

        // GET: HopDongs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HopDong hopDong = db.Hopdongs.Find(id);
            if (hopDong == null)
            {
                return HttpNotFound();
            }
            return View(hopDong);
        }

        // POST: HopDongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            HopDong hopDong = db.Hopdongs.Find(id);
            db.Hopdongs.Remove(hopDong);
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
