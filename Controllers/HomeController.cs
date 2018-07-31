using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IC_MVC_tutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string username, string password)
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

        public ActionResult Staff()
        {
            ViewBag.Message = "Your staff page, custom built tab.";

            return View();
        }
    }
}