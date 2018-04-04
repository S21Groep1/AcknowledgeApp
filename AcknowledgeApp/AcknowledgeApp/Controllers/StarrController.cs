using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AcknowledgeApp.Controllers
{
    public class StarrController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StarrList()
        {
            return View();
        }
    }
}