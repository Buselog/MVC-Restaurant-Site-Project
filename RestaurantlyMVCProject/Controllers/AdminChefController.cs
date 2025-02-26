using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantlyMVCProject.Context;
using RestaurantlyMVCProject.Entities;

namespace RestaurantlyMVCProject.Context
{
    [Authorize]
    public class AdminChefController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();

        public ActionResult ChefIndex()
        {
            var values = db.Tbl_Chef.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddNewChef()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewChef(Chef newChef)
        {
            db.Tbl_Chef.Add(newChef);
            db.SaveChanges();
            return RedirectToAction("ChefIndex");
        }

        public ActionResult DeleteChef(int id)
        {
            var values = db.Tbl_Chef.Find(id);
            db.Tbl_Chef.Remove(values);
            db.SaveChanges();
            return RedirectToAction("ChefIndex");
        }

        [HttpGet]
        public ActionResult UpdateChef(int id)
        {
            var values = db.Tbl_Chef.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateChef(Chef updatedChef)
        {
            var values = db.Tbl_Chef.Find(updatedChef.ChefId);
            values.ChefName = updatedChef.ChefName;
            values.ChefTitle = updatedChef.ChefTitle;
            values.ChefImageUrl = updatedChef.ChefImageUrl;
            db.SaveChanges();
            return RedirectToAction("ChefIndex");
        }
    }
}