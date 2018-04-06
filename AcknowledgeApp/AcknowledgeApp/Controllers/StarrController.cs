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

namespace AcknowledgeApp.Controllers
{
    public class StarrController : Controller
    {
        private Starr_Logic logic = new Starr_Logic();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StarrList()
        {
            StarrListViewModel viewmodel = new StarrListViewModel(logic.GetAllStarrs());

            return View(viewmodel);
        }

        public IActionResult EditStarr(int id)
        {
            Starrform sf = logic.GetStarrById(id);

            if (sf == null)
            {
                return NotFound(id);
            }


            return View(sf);
        }
        [HttpPost]
        public IActionResult EditStarr(Starrform starrform)
        {
            logic.UpdateStarr(starrform);
            return RedirectToAction("StarrList");
        }

    }
}