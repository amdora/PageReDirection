using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PageReDirection.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult page1()
        {
            return Redirect("https://yadorigi-myspace.com/?page_id=1367");///
        }
        [HttpPost]
        public ActionResult page2()
        {
            return Redirect("https://recovideocallwindows.azurewebsites.net");
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
    }
}