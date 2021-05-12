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
    public class DuAnsController : Controller
    {
        private DBConnect db = new DBConnect();

        // GET: DuAns
        public ActionResult Index()
        {
            if (Session["idAccount"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            return View(db.Duans.ToList());
        }

        // GET: DuAns/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DuAn duAn = db.Duans.Find(id);
            if (duAn == null)
            {
                return HttpNotFound();
            }
            return View(duAn);
        }

        // GET: DuAns/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DuAns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Ma_duan,TenDuan,Ngaybatdau,Ngayketthuc,SoLuong,Dongia,Chietkhau,Ma_nv")] DuAn duAn)
        {
            if (ModelState.IsValid)
            {
                db.Duans.Add(duAn);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(duAn);
        }

        // GET: DuAns/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DuAn duAn = db.Duans.Find(id);
            if (duAn == null)
            {
                return HttpNotFound();
            }
            return View(duAn);
        }

        // POST: DuAns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Ma_duan,TenDuan,Ngaybatdau,Ngayketthuc,SoLuong,Dongia,Chietkhau,Ma_nv")] DuAn duAn)
        {
            if (ModelState.IsValid)
            {
                db.Entry(duAn).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(duAn);
        }

        // GET: DuAns/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DuAn duAn = db.Duans.Find(id);
            if (duAn == null)
            {
                return HttpNotFound();
            }
            return View(duAn);
        }

        // POST: DuAns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DuAn duAn = db.Duans.Find(id);
            db.Duans.Remove(duAn);
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
