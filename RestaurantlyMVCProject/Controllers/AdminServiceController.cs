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
    public class AdminServiceController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();
        public ActionResult ServiceIndex()
        {
            var values = db.Tbl_Service.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddNewService()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewService(Service newService)
        {
            db.Tbl_Service.Add(newService);
            db.SaveChanges();
            return RedirectToAction("ServiceIndex");
        }

        public ActionResult DeleteService(int id)
        {
            var values = db.Tbl_Service.Find(id);
            db.Tbl_Service.Remove(values);
            db.SaveChanges();
            return RedirectToAction("ServiceIndex");
        }

        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var values = db.Tbl_Service.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateService(Service updatedService)
        {
            var values = db.Tbl_Service.Find(updatedService.ServiceId);
            values.ServiceTitle = updatedService.ServiceTitle;
            values.ServiceDescription = updatedService.ServiceDescription;
            db.SaveChanges();
            return RedirectToAction("ServiceIndex");
        }
    }
}