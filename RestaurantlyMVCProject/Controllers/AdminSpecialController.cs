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
    public class AdminSpecialController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();
        public ActionResult SpecialIndex()
        {
            var values = db.Tbl_Special.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddNewSpecial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewSpecial(Special newSpecial)
        {
            db.Tbl_Special.Add(newSpecial);
            db.SaveChanges();
            return RedirectToAction("SpecialIndex");
        }

        public ActionResult DeleteSpecial(int id)
        {
            var values = db.Tbl_Special.Find(id);
            db.Tbl_Special.Remove(values);
            db.SaveChanges();
            return RedirectToAction("SpecialIndex");
        }

        [HttpGet]
        public ActionResult UpdateSpecial(int id)
        {
            var values = db.Tbl_Special.Find(id);
            return View(values);
        }
        public ActionResult UpdateSpecial(Special updatedSpecial)
        {
            var values = db.Tbl_Special.Find(updatedSpecial.SpecialId);
            values.SpecialName = updatedSpecial.SpecialName;
            values.SpecialShortDescription = updatedSpecial.SpecialShortDescription;
            values.SpecialFullDescription = updatedSpecial.SpecialFullDescription;
            values.SpecialImageUrl = updatedSpecial.SpecialImageUrl;
            db.SaveChanges();
            return RedirectToAction("SpecialIndex");
        }
    }
}