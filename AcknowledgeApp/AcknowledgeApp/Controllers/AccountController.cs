using AcknowledgeApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Models;
using Logic;
using Microsoft.AspNetCore.Http;

namespace AcknowledgeApp.Controllers
{
    public class AccountController : Controller
    {
        UserLogic logic = new UserLogic();
        StarrLogic slogic = new StarrLogic();
        
        public IActionResult Index()
        {
            User user = logic.GetAccountByEmail(HttpContext.Session.GetString("Email"));
            return View(user);
        }

        public IActionResult CoachPage()
        {
            int userid = HttpContext.Session.GetInt32("Userid").GetValueOrDefault(0);
            CoachViewModel vm = new CoachViewModel(slogic.GetAllStarrsForCoach(userid));
            return View();
        }
    }

}