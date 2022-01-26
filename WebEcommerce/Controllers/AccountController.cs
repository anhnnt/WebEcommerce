using Microsoft.AspNetCore.Mvc;

namespace WebEcommerce.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
