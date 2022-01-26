using Microsoft.AspNetCore.Mvc;

namespace WebEcommerce.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PlaceOrder()
        {
            return View();
        }
    }
}
