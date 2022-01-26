using Microsoft.AspNetCore.Mvc;

namespace WebEcommerce.Areas.Admin.Controllers
{
    public class AdminCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
