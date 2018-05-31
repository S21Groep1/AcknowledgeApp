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
using RotativaHQ.AspNetCore;

namespace AcknowledgeApp.Controllers
{
    public class StarrController : Controller
    {
        private Starr_Logic logic = new Starr_Logic();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Starr s)
        {
            logic.addStarr(s);
            return RedirectToAction("StarrList");
        }

        public IActionResult StarrList()
        {
            StarrListViewModel viewmodel = new StarrListViewModel(logic.GetAllStarrs());

            return View(viewmodel);
        }

        public IActionResult EditStarr(int id)
        {
            Starr sf = logic.GetStarrById(id);

            if (sf == null)
            {
                return NotFound(id);
            }

            return View(sf);
        }

        public IActionResult AddActionPoint(int id)
        {
            Starr sf = logic.GetStarrById(id);
            Actionpoint p = new Actionpoint(DateTime.Now, "Improve writing", "test", "test", "test", "test");
            Actionpoint p1 = new Actionpoint(DateTime.Now, "Improve reading", "test", "test", "test", "test");
            Actionpoint p2 = new Actionpoint(DateTime.Now, "Improve listening", "test", "test", "test", "test");
            Actionpoint p3 = new Actionpoint(DateTime.Now, "Improve teamwork", "test", "test", "test", "test");
            Actionpoint p4 = new Actionpoint(DateTime.Now, "Improve testing", "test", "test", "test", "test");

            List<Actionpoint> points = new List<Actionpoint>();
            points.Add(p);
            points.Add(p1);
            points.Add(p2);
            points.Add(p3);
            points.Add(p4);

            ActionPointStarrViewModel viewmodel = new ActionPointStarrViewModel(points, sf);


            if (sf == null)
            {
                return NotFound(id);
            }

            return View(viewmodel);
        }

        [HttpPost]
        public IActionResult EditStarr(Starr starr)
        {
            logic.UpdateStarr(starr);
            return RedirectToAction("StarrList");
        }

        public IActionResult PrintStarr(int id)
        {
            var report = new ViewAsPdf("EditStarr");
            return report;
        }

    }
}