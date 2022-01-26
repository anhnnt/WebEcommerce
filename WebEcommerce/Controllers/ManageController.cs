using Microsoft.AspNetCore.Mvc;

namespace WebEcommerce.Controllers
{
    public class ManageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
