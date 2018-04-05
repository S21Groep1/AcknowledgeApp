using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcknowledgeApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AcknowledgeApp.Controllers
{
    public class ActionController : Controller
    {
        public IActionResult Index(Viewmodel viewmodel)
        {
            return View(viewmodel);
        }
    }
}