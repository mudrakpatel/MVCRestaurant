using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRestaurant.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "More details coming soon . . .";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Please keep in touch";

            return View();
        }
    }
}