using AcknowledgeApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Logic;
using Models;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Http;

namespace AcknowledgeApp.Controllers
{
    public class ActionController : Controller
    {
        private ActionpointLogic actionLogic = new ActionpointLogic();
        private UserLogic userLogic = new UserLogic();
        private StarrLogic starrLogic = new StarrLogic();

        public IActionResult Index(int id)
        {
            int userId = userLogic.GetAccountByEmail(HttpContext.Session.GetString("Email")).Id;

            List<string> Coaches = userLogic.GetAllCoachesNames();
            List<string> Softskills = starrLogic.GetAllSoftSkills();
            Actionpoint actionpoint = new Actionpoint();
            List<Actionpoint> actionpointList = actionLogic.GetAllActionpointsByUser(userId);
            Starr starr = starrLogic.GetStarrById(id);
            List<Starr> starrList = starrLogic.GetAllStarsForUser(userId);
            List<Actionpoint> allActionPoints = actionLogic.GetAllActionpointsByUser(userId);

            ActionPointStarrViewModel viewmodel = new ActionPointStarrViewModel(Coaches, Softskills, actionpoint, starr, actionpointList, allActionPoints, starrList);
            return View(viewmodel);
        }

        [HttpPost]
        public IActionResult AddActionpoint(ActionPointStarrViewModel viewModel)
        {
            Actionpoint actionpoint = viewModel.actionpoint;
            actionpoint.Id = viewModel.actionpoint.Id;
            actionpoint.UserId = userLogic.GetAccountByEmail(HttpContext.Session.GetString("Email")).Id;
            actionpoint.StartDate = DateTime.Now;
            actionpoint.LastEdit = DateTime.Now;
            actionpoint.Iscomplete = false;

            actionLogic.AddActionpoint(actionpoint);
            return RedirectToAction("StarrList", "Starr");
        }
    }
}