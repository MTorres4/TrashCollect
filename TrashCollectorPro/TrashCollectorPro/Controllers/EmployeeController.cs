using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrashCollectorPro.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Welcome()
        {
            return View();
        }

        public ActionResult Schedule()
        //Need CRUD
        {
            ViewBag.Message = "Your current route";

            return View();
        }
    }
}