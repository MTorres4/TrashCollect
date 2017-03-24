﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrashCollectorPro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.IsInRole("Admin"))
            {
                return RedirectToAction("Index", "Role");
            }
            if (User.IsInRole("Employee"))
            {
                return RedirectToAction("Welcome", "Employee");
            }
            if (User.IsInRole("User"))
            {
                return RedirectToAction("Welcome", "User");
            }
            return View();
            //Moved here from AccountController
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