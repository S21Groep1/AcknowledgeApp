using Logic;
using Microsoft.AspNetCore.Mvc;

namespace AcknowledgeApp.Controllers
{
    public class AccountController : Controller
    {
        private AccountLogic logic = new AccountLogic(LogicTypes.TestLogic);

        public IActionResult Index()
        {
            return View();
        }
    }
}