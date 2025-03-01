using System;
using System.Collections.Generic;
using System.IO;
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

            if (updatedAdmin.ImageFile != null)
            {
                var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                var saveLocation = currentDirectory + "images\\";
                var fileName = Path.Combine(saveLocation, updatedAdmin.ImageFile.FileName);
                updatedAdmin.ImageFile.SaveAs(fileName);
                values.ImageUrl = "/images/" + updatedAdmin.ImageFile.FileName;
            }

            db.SaveChanges();
            return Redirect(Request.UrlReferrer.ToString());

        }

        [HttpGet]
        public ActionResult ChangePasswordIndex()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult ChangePasswordIndex(Admin updatedAdmin)
        {

            var values = db.Tbl_Admin.Find(Session["userId"]);
            if (values.Password != updatedAdmin.CurrentPassword)
            {
                ModelState.AddModelError("", "Current password is incorrect");
                return View(updatedAdmin);
            }
            if (updatedAdmin.NewPassword != updatedAdmin.ConfirmPassword)
            {
                ModelState.AddModelError("", "Passwords do not match");
                return View(updatedAdmin);
            }

            values.Password = updatedAdmin.NewPassword;
            db.SaveChanges();
            return RedirectToAction("LogOut", "Login");
        }



    }
}