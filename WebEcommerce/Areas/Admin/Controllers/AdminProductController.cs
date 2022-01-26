﻿using Database.DomainModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebEcommerce.Services;

namespace WebEcommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminProductController : Controller
    {
        private readonly ProductService _productService;

        public AdminProductController(ProductService productService)
        {
            _productService = productService;
        }

        // GET: Admin/AdminProduct/Index
        public IActionResult Index()
        {
            return View(_productService.GetAllProducts());
        }

        // GET: Admin/AdminProduct/Details/
        public IActionResult Details(string id)
        {
            var Productdetail = _productService.GetProduct(id);
            return View(Productdetail);
        }

        // GET: AdminProductController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdminProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePost(Product product)
        {
            _productService.Create(product);
            return RedirectToAction("Index");
        }

        [HttpGet]
        // GET: AdminProductController/Edit/5
        public IActionResult Edit(string Id)
        {
            var productdetail = _productService.GetProduct(Id);
            return View(productdetail);
        }

        // POST: AdminProductController/Edit/5
        [HttpPost]
        public IActionResult Edit(string Id, Product productdata)
        {
            _productService.Update(Id, productdata);
            return RedirectToAction("Index");
        }

        // GET: AdminProductController/Delete/5
        public IActionResult Delete(string id)
        {
            var Productdetail = _productService.GetProduct(id);
            return View(Productdetail);
        }

        // POST: AdminProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(string id)
        {
            _productService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
