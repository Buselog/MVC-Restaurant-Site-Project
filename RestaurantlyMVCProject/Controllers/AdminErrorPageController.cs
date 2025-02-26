using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantlyMVCProject.Controllers
{
    public class AdminErrorPageController : Controller
    {
        public ActionResult ErrorPage404()
        {
            return View();
        }
    }
}