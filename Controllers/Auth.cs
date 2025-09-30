using Microsoft.AspNetCore.Mvc;

namespace dotnet_mvc_first_app.Controllers
{
    public class Auth : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
