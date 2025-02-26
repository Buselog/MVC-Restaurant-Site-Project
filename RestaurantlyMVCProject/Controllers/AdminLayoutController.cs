using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantlyMVCProject.Context;
using RestaurantlyMVCProject.Entities;

namespace RestaurantlyMVCProject.Controllers
{
    public class AdminLayoutController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();
        NavBarContent contents = new NavBarContent();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            ViewBag.NotificationCount = db.Tbl_Notification.Where(x => x.IsRead == false).Count();
            contents.Notifications = db.Tbl_Notification.Where(x => x.IsRead == false).ToList();
            ViewBag.MessagesCount = db.Tbl_Messages.Where(x => x.IsRead == false).Count();
            contents.Messages = db.Tbl_Messages.Where(x => x.IsRead == false).ToList();
            //var values = db.Tbl_Notification.Where(x => x.IsRead==false).ToList();
            return PartialView(contents);
        }
        public ActionResult NotificationStatusChange(int id)
        {
            var values = db.Tbl_Notification.Find(id);
            values.IsRead = true;
            db.SaveChanges();
            return Redirect(Request.UrlReferrer.ToString());
        }
        public ActionResult MessageStatusChange(int id)
        {
            var values = db.Tbl_Messages.Find(id);
            values.IsRead = true;
            db.SaveChanges();
            return Redirect(Request.UrlReferrer.ToString());
        }
        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}