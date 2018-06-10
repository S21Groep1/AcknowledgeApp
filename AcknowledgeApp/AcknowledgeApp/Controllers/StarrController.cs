using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;
using Logic;
using RotativaHQ.AspNetCore;
using Microsoft.AspNetCore.Http;
using AcknowledgeApp.ViewModels;
using System;

namespace AcknowledgeApp.Controllers
{
    public class StarrController : Controller
    {
        private UserLogic userLogic = new UserLogic();
        private StarrLogic starrLogic = new StarrLogic();
        private ActionpointLogic actionLogic = new ActionpointLogic();

        public IActionResult StarrList()
        {
            int userId = userLogic.GetAccountByEmail(HttpContext.Session.GetString("Email")).Id;
            List<string> Coaches = userLogic.GetAllCoachesNames();
            List<string> Softskills = starrLogic.GetAllSoftSkills();
            Actionpoint actionpoint = new Actionpoint();
            Starr starr = new Starr();
            List<Starr> starrList = starrLogic.GetAllStarsForUser(userId);
            List<Actionpoint> allActionPoints = actionLogic.GetAllActionpointsByUser(userId);
            List<Actionpoint> starrActionPoints = starr.Actionpoints;
            ActionPointStarrViewModel viewModel = new ActionPointStarrViewModel(Coaches, Softskills, actionpoint, starr, starrActionPoints, allActionPoints, starrList);

            return View(viewModel);
        }

        public IActionResult EditStarr(int id)
        {
            int userId = userLogic.GetAccountByEmail(HttpContext.Session.GetString("Email")).Id;
            List<string> Coaches = userLogic.GetAllCoachesNames();
            List<string> Softskills = starrLogic.GetAllSoftSkills();
            Actionpoint actionpoint = new Actionpoint();
            Starr starr = starrLogic.GetStarrById(id); ;
            List<Starr> starrList = starrLogic.GetAllStarsForUser(userId);
            List<Actionpoint> allActionPoints = actionLogic.GetAllActionpointsByUser(userId);
            List<Actionpoint> starrActionPoints = starr.Actionpoints;
            ActionPointStarrViewModel viewModel = new ActionPointStarrViewModel(Coaches, Softskills, actionpoint, starr, starrActionPoints, allActionPoints, starrList);

            return View(viewModel); 
        }

        [HttpPost]
        public IActionResult EditStarr(ActionPointStarrViewModel viewModel)
        {
            Starr starr = viewModel.starr;
            starr.UserId = userLogic.GetAccountByEmail(HttpContext.Session.GetString("Email")).Id;
            starr.CoachId = userLogic.GetCoachIdByName(viewModel.coachName);
            starr.LastEdit = DateTime.Now;
            starrLogic.UpdateStarr(starr);
            return RedirectToAction("StarrList");
        }

        public IActionResult PrintStarr(int id)
        {
            int userId = userLogic.GetAccountByEmail(HttpContext.Session.GetString("Email")).Id;
            List<string> Coaches = userLogic.GetAllCoachesNames();
            List<string> Softskills = starrLogic.GetAllSoftSkills();
            Actionpoint actionpoint = new Actionpoint();
            List<Actionpoint> actionpointList = actionLogic.GetAllActionpointsByUser(userId);
            Starr starr = starrLogic.GetStarrById(id);
            List<Actionpoint> allActionPoints = actionLogic.GetAllActionpointsByUser(userId);
            List<Actionpoint> starrActionPoints = starr.Actionpoints;
            List<Starr> starrList = starrLogic.GetAllStarsForUser(userId);
            ActionPointStarrViewModel viewModel = new ActionPointStarrViewModel(Coaches, Softskills, actionpoint, starr, starrActionPoints, allActionPoints, starrList);
            return new ViewAsPdf(viewModel);
        }

        public IActionResult AddStarr()
        {
            int userId = userLogic.GetAccountByEmail(HttpContext.Session.GetString("Email")).Id;

            List<string> Coaches = userLogic.GetAllCoachesNames();
            List<string> Softskills = starrLogic.GetAllSoftSkills();
            Actionpoint actionpoint = new Actionpoint();
            List<Actionpoint> actionpointList = actionLogic.GetAllActionpointsByUser(userId);
            Starr starr = new Starr();
            List<Actionpoint> allActionPoints = actionLogic.GetAllActionpointsByUser(userId);
            List<Actionpoint> starrActionPoints = starr.Actionpoints;
            List<Starr> starrList = starrLogic.GetAllStarsForUser(userId);
            ActionPointStarrViewModel viewModel = new ActionPointStarrViewModel(Coaches, Softskills, actionpoint, starr, starrActionPoints, allActionPoints, starrList);
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddStarr(ActionPointStarrViewModel viewModel)
        {
            Starr starr = viewModel.starr;
            starr.UserId = userLogic.GetAccountByEmail(HttpContext.Session.GetString("Email")).Id;
            starr.CoachId = userLogic.GetCoachIdByName(viewModel.coachName);
            starr.StartDate = DateTime.Now;
            starr.LastEdit = DateTime.Now;

            starrLogic.AddStarr(starr);
            return RedirectToAction("AddStarr", "Starr");
        }

        [HttpPost]
        public void AddActionPointToStarr([FromBody] int[] somearray)
        {
            int actionPointId = somearray[0];
            int starrId = somearray[1];
            actionLogic.AddActionPointToStarr(actionPointId, starrId);
        }
    }
}