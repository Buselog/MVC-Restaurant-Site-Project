using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using RestaurantlyMVCProject.Context;
using RestaurantlyMVCProject.Entities;
using System.Web.Mvc;

namespace RestaurantlyMVCProject.Controllers
{
    [Authorize]
    public class AdminProductController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();
        public ActionResult ProductIndex()
        {
            var values = db.Tbl_Product.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddNewProduct()
        {
            List<SelectListItem> values = (from x in db.Tbl_Category.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString(),
                                           }
                                           ).ToList();
            ViewBag.categories = values;
            return View();
        }

        [HttpPost]
        public ActionResult AddNewProduct(Product newProduct)
        {
            db.Tbl_Product.Add(newProduct);
            db.SaveChanges();
            return RedirectToAction("ProductIndex");
        }

        public ActionResult DeleteProduct(int id)
        {
            var values = db.Tbl_Product.Find(id);
            db.Tbl_Product.Remove(values);
            db.SaveChanges();
            return RedirectToAction("ProductIndex");
        }

        [HttpGet]
        public ActionResult UpdateProduct(int id)
        {
            List<SelectListItem> categories = (from x in db.Tbl_Category.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString(),
                                           }).ToList();
            ViewBag.categories = categories;
            var values = db.Tbl_Product.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateProduct(Product updatedProduct)
        {
            var values = db.Tbl_Product.Find(updatedProduct.ProductId);
            values.ProductName = updatedProduct.ProductName;
            values.ProductDescription = updatedProduct.ProductDescription;
            values.ProductPrice = updatedProduct.ProductPrice;
            values.ProductImageUrl = updatedProduct.ProductImageUrl;
            values.CategoryId = updatedProduct.CategoryId;
            db.SaveChanges();
            return RedirectToAction("ProductIndex");
        }

    }
}