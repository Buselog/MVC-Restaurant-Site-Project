using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using RestaurantlyMVCProject.Context;
using RestaurantlyMVCProject.Entities;

namespace RestaurantlyMVCProject.Controllers
{
    [Authorize]
    public class AdminGalleryController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();
        public ActionResult GalleryIndex()
        {
            var values = db.Tbl_Images.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddNewImage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewImage(Images newImage)
        {
            db.Tbl_Images.Add(newImage);
            db.SaveChanges();
            return RedirectToAction("GalleryIndex");
        }
        public ActionResult DeleteImage(int id)
        {
            var values = db.Tbl_Images.Find(id);
            db.Tbl_Images.Remove(values);
            db.SaveChanges();
            return RedirectToAction("GalleryIndex");
        }

        [HttpGet]
        public ActionResult UpdateImage(int id)
        {
            var values = db.Tbl_Images.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateImage(Images updatedImages)
        {
            var values = db.Tbl_Images.Find(updatedImages.ImagesId);
            values.ImageUrl = updatedImages.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("GalleryIndex");
        }
    }
}