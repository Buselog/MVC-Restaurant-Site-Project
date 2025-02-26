using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantlyMVCProject.Context;

namespace RestaurantlyMVCProject.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();
        public ActionResult DashboardIndex()
        {
            ViewBag.ProductCount = db.Tbl_Product.Count();
            ViewBag.LastProductName = db.Tbl_Product.OrderByDescending(x => x.ProductId).Select(x=>x.ProductName).FirstOrDefault();
            ViewBag.CategoryCount = db.Tbl_Category.Count();
            ViewBag.LastCategoryName = db.Tbl_Category.OrderByDescending(x => x.CategoryId).Select(x=>x.CategoryName).FirstOrDefault();
            ViewBag.SpecialCount = db.Tbl_Special.Count();
            ViewBag.LastSpecialName = db.Tbl_Special.OrderByDescending(x => x.SpecialId).Select(x=>x.SpecialName).FirstOrDefault();
            ViewBag.ReservationCount = db.Tbl_Reservation.Count();

            return View();
        }

        public PartialViewResult ReservationTablePartial()
        {
            var values = db.Tbl_Reservation.ToList();
            return PartialView(values);
        }


        public PartialViewResult StatisticFoodPartial()
        {
            var values = db.Tbl_Product.OrderByDescending(x => x.ProductId).Take(4).ToList();
            return PartialView(values);
        }

        public PartialViewResult MostExpensiveFoodPartial()
        {
            //For Starters
            decimal expensiveStarter = db.Tbl_Product.Where(x => x.CategoryId == 1).Max(x => x.ProductPrice);
            ViewBag.MostExpensiveStarter = db.Tbl_Product.Where(x => x.ProductPrice == expensiveStarter).ToList();

            // For Salads
            decimal expensiveSalad = db.Tbl_Product.Where(x => x.CategoryId == 2).Max(x => x.ProductPrice);
            ViewBag.MostExpensiveSalad = db.Tbl_Product.Where(x => x.ProductPrice == expensiveSalad).ToList();

            //For Specials
            decimal expensiveSpecial = db.Tbl_Product.Where(x => x.CategoryId == 3).Max(x => x.ProductPrice);
            ViewBag.MostExpensiveSpecial = db.Tbl_Product.Where(x => x.ProductPrice == expensiveSpecial).ToList();
            return PartialView();

        }

        public PartialViewResult LastSavedServicesPartial()
        {
            var values = db.Tbl_Service.OrderByDescending(x => x.ServiceId).Take(3).ToList();
            return PartialView(values);
        }
        public PartialViewResult LastSavedEventsPartial()
        {
            var values = db.Tbl_Event.OrderByDescending(x => x.EventId).Take(3).ToList();
            return PartialView(values);
        }





    }
}