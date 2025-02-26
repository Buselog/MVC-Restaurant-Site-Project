using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantlyMVCProject.Context;
using RestaurantlyMVCProject.Entities;

namespace RestaurantlyMVCProject.Controllers
{

    [Authorize]
    public class AdminProfileController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();

        [HttpGet]
        public ActionResult ProfileIndex()
        {
            var values = db.Tbl_Admin.Find(Session["userId"]);
            return View(values);
        }

        [HttpPost]
        public ActionResult ProfileIndex(Admin updatedAdmin)
        {
            var values = db.Tbl_Admin.Find(updatedAdmin.AdminId);
            values.Name = updatedAdmin.Name;
            values.Surname = updatedAdmin.Surname;
            values.Email = updatedAdmin.Email;
            values.UserName = updatedAdmin.UserName;
            values.Password = updatedAdmin.Password;
            values.ImageUrl = updatedAdmin.ImageUrl;
            db.SaveChanges();
            return Redirect(Request.UrlReferrer.ToString());

        }


    }
}