using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollectorPro.Models;

namespace TrashCollectorPro.Controllers
{
    public class UserController : Controller
    {
        private ApplicationDbContext db;

        public UserController()
        {
            db = new ApplicationDbContext();
        }

        // GET: User
        public ActionResult Welcome()
        //public ActionResult Welcome()
        //public string Welcome()
        {
            //var userId = User.Identity.GetUserId();
            //var currentUserZip = db.Users.Where(x => x.Id == userId).First().ZipCode;
            //var employeeRoleId = db.Roles.Where(x => x.Name == "Employee").First().Id;
            //var employees = db.Users.Where(x => x.Roles.ToList()[0].RoleId == employeeRoleId).ToList();

            //if (employees.Select(x => x.ZipCode).Contains(currentUserZip))
            //{
            //    return ViewBag("You are in our system!");
            //}
            //else
            //{
            //    return View("Unfortunately, we don't service your area yet, but we will email you as soon as we can service your area!");
            //}
            return View();
            //return "Welcome!";
        }

        public ActionResult Schedule()
            //Need CRUD
        {
            ViewBag.Message = "Change your current pick-up";
            //var userId = User.Identity.GetUserId();
            //var currentPickUpDay = db.Users.Where();

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }
    }
}