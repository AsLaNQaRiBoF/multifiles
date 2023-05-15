using Microsoft.AspNetCore.Mvc;

namespace NestApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
