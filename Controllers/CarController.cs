using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassLibrary1;

namespace IC_MVC_tutorial.Controllers
{
    public class CarController : Controller
    {
        [HttpGet]
        // GET: Car
        public ActionResult CarIndex()
        {
            return View();
        }
    }
}