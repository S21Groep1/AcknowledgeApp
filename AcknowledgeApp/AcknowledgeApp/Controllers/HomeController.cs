using System;
using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace AcknowledgeApp.Controllers
{
    public class HomeController : Controller
    {
        UserLogic logic = new UserLogic();

        [TempData]
        private string ErrorMessage { get; set; }

        public IActionResult Index()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Email")))
            {
                ViewData["ErrorMessage"] = ErrorMessage;
                return View();
            }
            return RedirectToAction("Homepage", "Home");
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            try
            {
                User u = new User() { Email = user.Email, Password = user.Password };
                logic.Login(u);
                HttpContext.Session.SetString("Email", u.Email);
                HttpContext.Session.SetInt32("Userid",u.Id);
                return RedirectToAction("Index", "TwoFactor");
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                ViewData["ErrorMessage"] = ErrorMessage;
                return View();
            }
        }

        public IActionResult Homepage()
        {
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}