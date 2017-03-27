using Microsoft.AspNet.Identity;
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
        private ApplicationDbContext db;
        
        public EmployeeController()
        {
            db = new ApplicationDbContext();
        }

        // GET: Employee
        public ActionResult Welcome()
        {
            return View();
        }

        public ActionResult Schedule()
        //Need CRUD
        {
            var userRoleId = db.Roles.Where(x => x.Name == "User").First().Id;
            var users = db.Users.Where(x => x.Roles.FirstOrDefault().RoleId == userRoleId).ToList();
            var employeeId = User.Identity.GetUserId();
            var currentEmployeeZip = db.Users.Where(x => x.Id == employeeId).First().ZipCode;

            if(users.Select(x => x.ZipCode).Contains(currentEmployeeZip))
            {
                return View();
            }
            else
            {
                return View("NoRoute");
            }
        }
    }
}