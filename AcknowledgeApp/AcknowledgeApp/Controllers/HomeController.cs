using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AcknowledgeApp.Models;

namespace AcknowledgeApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Returns .../Home/Homepage
        public ActionResult Homepage()
        {
            return View();
        }
    }
}
