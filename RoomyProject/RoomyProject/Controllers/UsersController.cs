using RoomyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoomyProject.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users
        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
}