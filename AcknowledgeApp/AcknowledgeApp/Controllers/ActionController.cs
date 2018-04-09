using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcknowledgeApp.Models;
using Microsoft.AspNetCore.Mvc;
using Models;


namespace AcknowledgeApp.Controllers
{
    public class ActionController : Controller
    {
        public IActionResult Index(Viewmodel viewmodel)
        {
            viewmodel.Softskilllist();
            return View(viewmodel);
        }

        [HttpPost]
        public IActionResult Post(Actionpoint actionpoint)
        {

            return View();
        }
    }
}