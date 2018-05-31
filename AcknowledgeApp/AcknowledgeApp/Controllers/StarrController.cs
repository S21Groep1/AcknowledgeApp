using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcknowledgeApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite.Internal.ApacheModRewrite;
using Microsoft.AspNetCore.Rewrite.Internal.IISUrlRewrite;
using Models;
using Logic;
using AcknowledgeApp.ViewModels;
using DAL;

namespace AcknowledgeApp.Controllers
{
    public class StarrController : Controller
    {
        private Starr_Logic logic = new Starr_Logic(StorageType.Memory);

        public IActionResult AddStarr()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStarr(StarrViewModel vStarr)
        {
            if (ModelState.IsValid)
            {
                logic.Create(new Starr() { Name = vStarr.Name, Situation = vStarr.Situation, Task = vStarr.Task, Action = vStarr.Action, Result = vStarr.Result, Reflection = vStarr.Reflection, Feeling = vStarr.Feeling, Coach = vStarr.Coach, StartDate = DateTime.Now, LastEdit = DateTime.Now });
                return RedirectToAction("StarrList");
            }
            return View(vStarr);
        }

        public IActionResult StarrList()
        {
            return View(logic.GetAll());
        }

        public IActionResult EditStarr(int id)
        {
            if(id == 0)
            {
                return View();
            }
            Starr sf = logic.Get(id);
            return View(sf);
        }
        [HttpPost]
        public IActionResult EditStarr(StarrViewModel vStarr)
        {
            if (ModelState.IsValid)
            {
                logic.UpdateStarr(new Starr() { Id = vStarr.Id, Name = vStarr.Name, Situation = vStarr.Situation, Task = vStarr.Task, Action = vStarr.Action, Result = vStarr.Result, Reflection = vStarr.Reflection, Feeling = vStarr.Feeling, Coach = vStarr.Coach, LastEdit = DateTime.Now });
                return RedirectToAction("StarrList");
            }
            return View();
        }

    }
}