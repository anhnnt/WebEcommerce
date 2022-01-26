using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Test.Interface;
using Test.Models;

namespace Test.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomer _context;

        public CustomerController(ICustomer context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.GetAllCustomers());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePost(Customer Customerdata)
        {
            _context.Create(Customerdata);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(string Id)
        {
            var Customerdetail = _context.GetCustomer(Id);
            return View(Customerdetail);
        }

        [HttpPost]
        public IActionResult EditPost(string Id, Customer Customerdata)
        {
            _context.Update(Id, Customerdata);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(string Id)
        {
            var Customerdetail = _context.GetCustomer(Id);
            return View(Customerdetail);
        }

        [HttpGet]
        public IActionResult Delete(string Id)
        {
            var Customerdetail = _context.GetCustomer(Id);
            return View(Customerdetail);
        }

        [HttpPost]
        public IActionResult DeletePost(string Id)
        {
            _context.Delete(Id);
            return RedirectToAction("Index");
        }

    }
}
