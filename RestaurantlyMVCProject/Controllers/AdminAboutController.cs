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
    public class AdminAboutController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();

        public ActionResult AboutIndex()
        {
            var values = db.Tbl_About.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var values = db.Tbl_About.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateAbout(About updatedAbout)
        {
            var values = db.Tbl_About.Find(updatedAbout.AboutId);
            values.AboutTitle = updatedAbout.AboutTitle;
            values.AboutSubtitle = updatedAbout.AboutSubtitle;
            values.AboutImageUrl = updatedAbout.AboutImageUrl;
            db.SaveChanges();
            return RedirectToAction("AboutIndex");
        }
    }
}