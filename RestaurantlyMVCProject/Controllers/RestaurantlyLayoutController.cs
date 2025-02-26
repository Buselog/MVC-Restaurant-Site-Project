using System;
using System.Linq;
using System.Web.Mvc;
using RestaurantlyMVCProject.Context;
using RestaurantlyMVCProject.Entities;

namespace RestaurantlyMVCProject.Controllers
{
    [AllowAnonymous]
    public class RestaurantlyLayoutController : Controller
    {

        RestaurantlyContext db = new RestaurantlyContext();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialTopBar()
        {
            ViewBag.Call = db.Tbl_Address.Select(x => x.AddressCall).FirstOrDefault();
            ViewBag.OpenHours = db.Tbl_Address.Select(x => x.AddressOpenHours).FirstOrDefault();
            return PartialView();
        }

        public PartialViewResult PartialNavBar()
        {
            return PartialView();
        }

        public PartialViewResult PartialFeature()
        {
            ViewBag.Title = db.Tbl_Feature.Select(x => x.FeatureTitle).FirstOrDefault();
            ViewBag.Subtitle = db.Tbl_Feature.Select(x => x.FeatureSubtitle).FirstOrDefault();
            ViewBag.VideoUrl = db.Tbl_Feature.Select(x => x.FeatureVideoUrl).FirstOrDefault();
            return PartialView();
        }

        public PartialViewResult PartialAbout()
        {
            ViewBag.Title = db.Tbl_About.Select(x => x.AboutTitle).FirstOrDefault();
            ViewBag.Subtitle = db.Tbl_About.Select(x => x.AboutSubtitle).FirstOrDefault();
            ViewBag.ImageUrl = db.Tbl_About.Select(x => x.AboutImageUrl).FirstOrDefault();
            return PartialView();
        }

        public PartialViewResult PartialService()
        {
            var values = db.Tbl_Service.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialMenu()
        {
            var values = db.Tbl_Product.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialContact()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult ContactAdd(Contact newContact)
        {
            newContact.ContactSendDate = DateTime.Now;
            newContact.ContactIsRead = false;
            db.Tbl_Contact.Add(newContact);

            Messages newMessage = new Messages();
            newMessage.SenderName = "1 new contact request";
            newMessage.SendDate = DateTime.Now;
            newMessage.Message = "Contact request: " + newContact.ContactName+ ". Please check contact box";
            newMessage.Icon = "fa-solid fa-plus";
            newMessage.IconColor = "green";
            newMessage.IsRead = false;
            db.Tbl_Messages.Add(newMessage);

            db.SaveChanges();
            ViewBag.Message = "Success!";
            return View("Index");
        }

        public PartialViewResult PartialSpecial()
        {
            var values = db.Tbl_Special.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialBookTable()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult BookTableAdd(Reservation newReservation)
        {
            newReservation.ReservationSatatus = "On Hold";
            db.Tbl_Reservation.Add(newReservation);

            Notification newNotificationForReservation = new Notification();
            newNotificationForReservation.Title = "1 new booking request";
            newNotificationForReservation.SendTime = DateTime.Now;
            newNotificationForReservation.Icon = "fa-calendar-check";
            newNotificationForReservation.IconColor = "green";
            newNotificationForReservation.IsRead = false;
            db.Tbl_Notification.Add(newNotificationForReservation);

            db.SaveChanges();
            ViewBag.Message= "Reservation process successful!";
            return View("Index");
        }

        public PartialViewResult PartialTestimonial()
        {
            var values = db.Tbl_Testimonial.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialChef()
        {
            var values = db.Tbl_Chef.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAddress()
        {
            ViewBag.Location = db.Tbl_Address.Select(x => x.AddressLocation).FirstOrDefault();
            ViewBag.OpenHours = db.Tbl_Address.Select(x => x.AddressOpenHours).FirstOrDefault();
            ViewBag.Email = db.Tbl_Address.Select(x => x.AddressEmail).FirstOrDefault();
            ViewBag.Call = db.Tbl_Address.Select(x => x.AddressCall).FirstOrDefault();
            return PartialView();
        }

        public PartialViewResult PartialEvent()
        {
            var values = db.Tbl_Event.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialGallery()
        {
            var values = db.Tbl_Images.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialFooter()
        {
            ViewBag.Address = db.Tbl_Address.Select(x => x.AddressLocation).FirstOrDefault();
            ViewBag.Phone = db.Tbl_Address.Select(x => x.AddressCall).FirstOrDefault();
            ViewBag.Email = db.Tbl_Address.Select(x => x.AddressEmail).FirstOrDefault();
            return PartialView();
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}