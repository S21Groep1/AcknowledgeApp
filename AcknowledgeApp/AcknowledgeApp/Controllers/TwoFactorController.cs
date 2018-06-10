using System;
using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace AcknowledgeApp.Controllers
{
    public class TwoFactorController : Controller
    {
        UserLogic logic = new UserLogic();

        [TempData]
        private string ErrorMessage { get; set; }

        public IActionResult Index()
        {
            ViewData["ErrorMessage"] = ErrorMessage;
            return View();
        }

        [HttpPost]
        public IActionResult Index(Authentication auth)
        {
            try
            {
                int userId = logic.GetAccountByEmail(HttpContext.Session.GetString("Email")).Id;
                logic.PerformAuthentication(auth, userId);
                return RedirectToAction("Homepage", "Home");
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return View();
            }
        }
    }
}