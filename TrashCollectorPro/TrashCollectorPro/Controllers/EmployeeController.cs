using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollectorPro.Models;

namespace TrashCollectorPro.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Employee
        public ActionResult Welcome()
        {
            //var address = db.Users.Include(a => a).Include
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