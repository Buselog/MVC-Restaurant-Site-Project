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
    public class AdminEventController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();
        public ActionResult EventIndex()
        {
            var values = db.Tbl_Event.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddNewEvent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewEvent(Event newEvent)
        {
            db.Tbl_Event.Add(newEvent);
            db.SaveChanges();
            return RedirectToAction("EventIndex");
        }

        public ActionResult DeleteEvent(int id)
        {
            var values = db.Tbl_Event.Find(id);
            db.Tbl_Event.Remove(values);
            db.SaveChanges();
            return RedirectToAction("EventIndex");
        }

        [HttpGet]
        public ActionResult UpdateEvent(int id)
        {
            var values = db.Tbl_Event.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateEvent(Event updatedEvent)
        {
            var values = db.Tbl_Event.Find(updatedEvent.EventId);
            values.EventTitle = updatedEvent.EventTitle;
            values.EventPriceRange = updatedEvent.EventPriceRange;
            values.Description = updatedEvent.Description;
            values.EventImageUrl = updatedEvent.EventImageUrl;
            db.SaveChanges();
            return RedirectToAction("EventIndex");
        }
    }
}