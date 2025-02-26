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
    public class AdminReservationController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();
        public ActionResult ReservationIndex()
        {
            var values = db.Tbl_Reservation.ToList();
            return View(values);
        }

        public ActionResult ApproveReservation(int id)
        {
            var values = db.Tbl_Reservation.Find(id);
            values.ReservationSatatus = "Approved";
            db.SaveChanges();
            return Redirect(Request.UrlReferrer.ToString());
        }

        public ActionResult HoldReservation(int id)
        {
            var values = db.Tbl_Reservation.Find(id);
            values.ReservationSatatus = "On Hold";
            db.SaveChanges();
            return Redirect(Request.UrlReferrer.ToString());
        }
        public ActionResult RejectReservation(int id)
        {
            var values = db.Tbl_Reservation.Find(id);
            values.ReservationSatatus = "Reject";
            db.SaveChanges();
            return Redirect(Request.UrlReferrer.ToString());
        }
    }
}