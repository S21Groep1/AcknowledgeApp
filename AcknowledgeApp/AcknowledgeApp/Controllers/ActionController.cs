using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcknowledgeApp.Models;
using Microsoft.AspNetCore.Mvc;
using Logic;
using Models;


namespace AcknowledgeApp.Controllers
{
    public class ActionController : Controller
    {
        private Actionpoint_Logic logic = new Actionpoint_Logic();

        public IActionResult Index(Viewmodel viewmodel)
        {
            viewmodel.Softskilllist();
            return View(viewmodel);
        }

        [HttpPost]
        public IActionResult AddActionpoint(Actionpoint actionpoint)
        {
            logic.AddActionpoint(actionpoint);
            return RedirectToAction("Index");
        }
    }
}