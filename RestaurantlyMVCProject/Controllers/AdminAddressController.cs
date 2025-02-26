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
    public class AdminAddressController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();

        public ActionResult AddressIndex()
        {
            var values = db.Tbl_Address.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult UpdateAddress(int id)
        {
            var values = db.Tbl_Address.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateAddress(Address updatedAddress)
        {
            var values = db.Tbl_Address.Find(updatedAddress.AddressId);
            values.AddressLocation = updatedAddress.AddressLocation;
            values.AddressOpenHours = updatedAddress.AddressOpenHours;
            values.AddressEmail = updatedAddress.AddressEmail;
            values.AddressCall = updatedAddress.AddressCall;
            db.SaveChanges();
            return RedirectToAction("AddressIndex");
        }
    }
}