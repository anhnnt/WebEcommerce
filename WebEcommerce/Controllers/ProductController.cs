using Database.DomainModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebEcommerce.Services;

namespace WebEcommerce.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View(_productService.GetAllProducts());
        }

        public IActionResult ProductDetail(string id)
        {
            var Productdetail = _productService.GetProduct(id);
            return View(Productdetail);
        }

        public IActionResult SortProductByLowPrice()
        {
            return View(_productService.SortLowPrice());
        }

        public IActionResult SortProductByHighPrice()
        {
            return View(_productService.SortHighPrice());
        }

        [HttpPost]
        public IActionResult SearchProduct(string name)
        {
            return View(_productService.SearchProduct(name));
        }
    }
}
