using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectronicShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ChildActionOnly]
        public ActionResult Slide()
        {
            return PartialView("_slide");
        }

        [ChildActionOnly]
        public ActionResult Brand()
        {
            return PartialView("_brand");
        }

        [ChildActionOnly]
        public ActionResult Category()
        {
            return PartialView("_category");
        }

        [ChildActionOnly]
        public ActionResult CategoryTab()
        {
            return PartialView("_categoryTab");
        }

        [ChildActionOnly]
        public ActionResult New()
        {
            return PartialView("_new");
        }

        [ChildActionOnly]
        public ActionResult Recommended()
        {
            return PartialView("_recommended");
        }
    }
}