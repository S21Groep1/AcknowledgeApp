using Logic;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;

namespace AcknowledgeApp.Controllers
{
    public class HomeController : Controller
    {
        AccountLogic logic = new AccountLogic(LogicTypes.TestLogic);

        [TempData]
        public string ErrorMessage { get; set; }

        public IActionResult Index()
        {
            ViewData["Error"] = ErrorMessage;
            return View();
        }

        [HttpPost]
        public IActionResult Index(string email, string password)
        {
            try
            {
                logic.Login(new Account() { Email = email, Password = password });
                return RedirectToAction("Homepage", "Home");
            }
            catch(Exception ex)
            {
                ErrorMessage = ex.Message;
                return RedirectToAction("Index", "Home");
            }
            
        }

        // Returns .../Home/Homepage
        public ActionResult Homepage()
        {
            //property's email and wachtwoord are setted
            return View();
        }
    }
}