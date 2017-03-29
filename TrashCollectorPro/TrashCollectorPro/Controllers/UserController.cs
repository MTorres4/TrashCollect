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
            //var employees = db.Users.Where(x => x.Roles.First().RoleId == employeeRoleId).ToList();

            var employeeRoleId = db.Roles.Where(x => x.Name == "Employee").First().Id;
            var employees = db.Users.Where(x => x.Roles.FirstOrDefault().RoleId == employeeRoleId).ToList();
            var userId = User.Identity.GetUserId();
            var currentUserZip = db.Users.Where(x => x.Id == userId).First().ZipCode;


            if (employees.Select(x => x.ZipCode).Contains(currentUserZip))
            {
                ViewBag.Message = "We look forward to working with you!";
                //TempData["message"] = "We look forward to working with you!";
            }
            else
            {
                //Can I force thier active status to false?
                ViewBag.Message = "Unfortunately, we don't service your area yet, but we will email you as soon as we can service your area!";
                //TempData["message"] = "Unfortunately, we do not service your zipcode area yet, but we will email you as soon as we get a TrashDash collector your way!";
            }
            return View();
            //return "Welcome!";
        }

        public ActionResult Schedule()
        {
            return View();
        }
        
        public ActionResult Change(UserViewModels userview)
            //Need CRUD
        {
            ViewBag.Message = "View your current pick-up status";
            var userId = User.Identity.GetUserId();
            //var currentPickUpDay = db.Users.Where(x => x.Id == userId).First().CurrentPickUpDay;
            var user = db.Users.Single(m => m.Id == userId);
            user.CurrentPickUpDay = userview.CurrentPickUpDay;
            user.CurrentlyActive = userview.CurrentlyActive;
            user.SuspendService = userview.SuspendService;
            user.ResumeService = userview.ResumeService;

            db.SaveChanges();

            return View("Schedule", userview);
        }

        public ActionResult Invoice()
        {
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