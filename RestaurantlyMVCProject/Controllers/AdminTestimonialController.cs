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
    public class AdminTestimonialController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();

        public ActionResult TestimonialIndex()
        {
            var values = db.Tbl_Testimonial.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddNewTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewTestimonial(Testimonial newTestimonial)
        {
            db.Tbl_Testimonial.Add(newTestimonial);
            db.SaveChanges();
            return RedirectToAction("TestimonialIndex");
        }

        public ActionResult DeleteTestimonial(int id)
        {
            var values = db.Tbl_Testimonial.Find(id);
            db.Tbl_Testimonial.Remove(values);
            db.SaveChanges();
            return RedirectToAction("TestimonialIndex");
        }

        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var values = db.Tbl_Testimonial.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial updatedTestimonial)
        {
            var values = db.Tbl_Testimonial.Find(updatedTestimonial.TestimonialId);
            values.TestimonialName = updatedTestimonial.TestimonialName;
            values.TestimonialTitle = updatedTestimonial.TestimonialTitle;
            values.TestimonialDescription = updatedTestimonial.TestimonialDescription;
            values.TestimonialImageUrl = updatedTestimonial.TestimonialImageUrl;
            db.SaveChanges();
            return RedirectToAction("TestimonialIndex");
        }

    }
}