using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassLibrary1;

namespace IC_MVC_tutorial.Controllers
{
    public class StaffController : Controller
    {
        [HttpGet]
        // GET: Staff
        public ActionResult Index()
        {
            //using (var db = new StuffEntities())
            //{
            //    var users = db.Users.ToList();
            //}

            return View();
        }

       public JsonResult GetUser()
        {
            using (var db = new StuffEntities())
            {
                var users = db.Users.Select(x => new { Name= x.FirstName + " " + x.LastName, x.Id }).ToList();
                return Json(users, JsonRequestBehavior.AllowGet);
            }
             
        }
    }
}