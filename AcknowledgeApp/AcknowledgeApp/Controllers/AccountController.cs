using Microsoft.AspNetCore.Mvc;
using Models;
using Logic;
using Microsoft.AspNetCore.Http;

namespace AcknowledgeApp.Controllers
{
    public class AccountController : Controller
    {
        UserLogic logic = new UserLogic();
        
        public IActionResult Index()
        {
            User user = logic.GetAccountByEmail(HttpContext.Session.GetString("Email"));
            return View(user);
        }
    }
}