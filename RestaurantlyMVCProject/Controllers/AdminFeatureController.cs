using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using RestaurantlyMVCProject.Context;
using RestaurantlyMVCProject.Entities;

namespace RestaurantlyMVCProject.Controllers
{
    [Authorize]
    public class AdminFeatureController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();
        public ActionResult FeatureIndex()
        {
            var values = db.Tbl_Feature.ToList();
            return View(values);
        }

        public ActionResult DeleteFeature(int id)
        {
            var values = db.Tbl_Feature.Find(id);
            db.Tbl_Feature.Remove(values);
            db.SaveChanges();
            return RedirectToAction("FeatureIndex");
        }

        [HttpGet]
        public ActionResult UpdateFeature(int id)
        {
            var values = db.Tbl_Feature.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateFeature(Feature updatedFeature)
        {
            var values = db.Tbl_Feature.Find(updatedFeature.FeatureId);
            values.FeatureTitle = updatedFeature.FeatureTitle;
            values.FeatureSubtitle = updatedFeature.FeatureSubtitle;
            values.FeatureImageUrl = updatedFeature.FeatureImageUrl;
            values.FeatureVideoUrl = updatedFeature.FeatureVideoUrl;
            db.SaveChanges();
            return RedirectToAction("FeatureIndex");
        }
    }
}