using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using RestaurantlyMVCProject.Context;
using RestaurantlyMVCProject.Entities;

namespace RestaurantlyMVCProject.Controllers
{
    public class LoginController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();

        [HttpGet]
        public ActionResult LoginIndex()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginIndex(Admin admin)
        {
            var adminInfo = db.Tbl_Admin.FirstOrDefault(x => x.UserName == admin.UserName && x.Password == admin.Password);
            if (adminInfo != null)
            {
                FormsAuthentication.SetAuthCookie(adminInfo.UserName, false);
                Session["admin"] = adminInfo.UserName;
                Session["userId"] = adminInfo.AdminId;
                Session["userName"] = adminInfo.Name;
                Session["userSurname"] = adminInfo.Surname;
                Session["userImage"] = adminInfo.ImageUrl;
                return RedirectToAction("ProfileIndex", "AdminProfile");
            }
            else
            {
                return View();
            }

        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("LoginIndex", "Login");
        }
    }
}


