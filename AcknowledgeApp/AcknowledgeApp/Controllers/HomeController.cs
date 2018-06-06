using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace AcknowledgeApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            return View(user);
        }

        // Returns .../Home/Homepage
        public ActionResult Homepage()
        {
            //property's email and wachtwoord are setted
            return View();
        }
    }
}
