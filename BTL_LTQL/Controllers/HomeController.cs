using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using BTL_LTQL.Models;

namespace BTL_LTQL.Controllers
{
    public class HomeController : Controller
    {
        DBConnect db = new DBConnect();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View(); 
        } 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login( string email, string password)
        {
            if(ModelState.IsValid)
            {
                var ma_hoa_du_lieu = GETMD5(password);
                var kiem_tra_tai_khoan = db.Accounts.Where(s => s.email.Equals(email) && s.password.Equals(ma_hoa_du_lieu)).ToList();
                if(kiem_tra_tai_khoan != null )
                {
                    Session["idAccount"] = kiem_tra_tai_khoan.FirstOrDefault().id;
                    Session["ten"] = kiem_tra_tai_khoan.FirstOrDefault().Name;
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.LoginError = "Đăng nhập không thành công";
                    return RedirectToAction("Login");
                }  
            }    
            return View(); 
        }
        public ActionResult Logout()
        {
            Session.Clear();//remove session
            return RedirectToAction("Login");
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Account kh)
        {
            if(ModelState.IsValid)
            {
                var checkEmail = db.Accounts.FirstOrDefault(m => m.email == kh.email);
                if(checkEmail == null)
                {
                    kh.password = GETMD5(kh.password);
                    db.Configuration.ValidateOnSaveEnabled = false; 
                    db.Accounts.Add(kh);
                    db.SaveChanges();
                    return RedirectToAction("Login");
                } 
                else
                {
                    ViewBag.EmailError = "Email đã tồn tại";
                    return RedirectToAction("Register");
                }                    
            }
            return View();
        }
        public static string GETMD5(string pass)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(pass);
            byte[] targetData = md5.ComputeHash(fromData);
            string Mk_da_ma_hoa = null;
            for (int i = 0; i < targetData.Length; i++)
            {
                Mk_da_ma_hoa += targetData[i].ToString("x2");

            }
            return Mk_da_ma_hoa;


        }
    }
}