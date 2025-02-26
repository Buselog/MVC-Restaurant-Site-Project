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
    public class AdminCategoryController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();
        public ActionResult CategoryIndex()
        {
            var values = db.Tbl_Category.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddNewCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewCategory(Category newCategory)
        {
            db.Tbl_Category.Add(newCategory);
            db.SaveChanges();
            return RedirectToAction("CategoryIndex");
        }

        public ActionResult DeleteCategory(int id)
        {
            var values = db.Tbl_Category.Find(id);
            db.Tbl_Category.Remove(values);
            db.SaveChanges();
            return RedirectToAction("CategoryIndex");
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var values = db.Tbl_Category.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateCategory(Category updatedCategory)
        {
            var values = db.Tbl_Category.Find(updatedCategory.CategoryId);
            values.CategoryName = updatedCategory.CategoryName;
            db.SaveChanges();
            return RedirectToAction("CategoryIndex");
        }
    }
}