using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrashCollectorPro.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Welcome()
        //public string Welcome()
        {
            return View();
            //return "Welcome!";
        }
    }
}