using Microsoft.AspNetCore.Mvc;

namespace AuthenticationDemo.API.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
