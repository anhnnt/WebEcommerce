using Microsoft.AspNetCore.Mvc;

namespace WebEcommerce.Areas.Admin.Controllers
{
    public class AdminOrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
