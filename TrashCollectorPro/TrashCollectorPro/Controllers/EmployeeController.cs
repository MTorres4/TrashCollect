using Microsoft.AspNet.Identity;
using Microsoft.Owin.BuilderProperties;
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
        public List<Addresses> routeAddresses;
        private int counter;
        public int Count { get { return counter; } }
        
        public EmployeeController()
        {
            db = new ApplicationDbContext();
            routeAddresses = new List<Addresses>();
        }

        // GET: Employee
        public ActionResult Welcome()
        {
            return View();
        }

        public void DetermineIfRouteExists()
        //Need CRUD
        {
            var userRoleId = db.Roles.Where(x => x.Name == "User").First().Id;
            var users = db.Users.Where(x => x.Roles.FirstOrDefault().RoleId == userRoleId).ToList();
            var employeeId = User.Identity.GetUserId();
            var currentEmployeeZip = db.Users.Where(x => x.Id == employeeId).First().ZipCode;
            var currentEmployeeDay = db.Users.Where(x => x.Id == employeeId).First().CurrentPickUpDay;

            //if(users.Select(x => x.ZipCode).Contains(currentEmployeeZip) && (users.Select(x => x.CurrentPickUpDay).Contains(currentEmployeeDay)))
            for (int i = 0; i < users.Count; i++)
            {
                //if (users.Select(x => x.ZipCode).Contains(currentEmployeeZip) && (users.Select(x => x.CurrentPickUpDay).Contains(currentEmployeeDay)))
                if (users[i].ZipCode == currentEmployeeZip && users[i].CurrentPickUpDay == currentEmployeeDay)
                {
                    Route(users[i].Id);
                    counter++;
                }
            }
        }

        public void Route(string userId)
        {
            Addresses addresses = new Addresses();
            addresses.Street = db.Users.Where(x => x.Id == userId).First().Street;
            addresses.City = db.Users.Where(x => x.Id == userId).First().City;
            addresses.State = db.Users.Where(x => x.Id == userId).First().State;
            addresses.ZipCode = db.Users.Where(x => x.Id == userId).First().ZipCode;
            routeAddresses.Add(addresses);
        }

        public ActionResult Schedule()
        {
            DetermineIfRouteExists();
            if(counter > 0)
            {
                return View("Schedule", routeAddresses);
            }
            else
            {
                return View("NoRoute");
            }
        }
    }
}