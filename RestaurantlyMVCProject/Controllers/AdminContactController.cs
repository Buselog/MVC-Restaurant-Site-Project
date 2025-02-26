using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantlyMVCProject.Context;


namespace RestaurantlyMVCProject.Controllers
{
    [Authorize]
    public class AdminContactController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();
        public ActionResult ContactIndex()
        {
            var values = db.Tbl_Contact.ToList();
            return View(values);
        }

        public ActionResult DeleteContact(int id)
        {
            var values = db.Tbl_Contact.Find(id);
            db.Tbl_Contact.Remove(values);
            db.SaveChanges();
            return RedirectToAction("ContactIndex");
        }
    }
}