using Microsoft.AspNetCore.Mvc;

namespace dotnet_mvc_first_app.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
