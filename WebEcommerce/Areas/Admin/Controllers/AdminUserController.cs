using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using WebEcommerce.Models;
using System;
using System.Collections.Generic;

namespace WebEcommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminUserController : Controller
    {

        // GET: Admin/AdminUser
        //public IActionResult Index() 
        //{
        //    IEnumerable<User> model = _userServices.GetAllAsync;
        //    return View(model);
        //}

        ////GET: Admin/AdminUser/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        ////POST
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(Category obj)
        //{
        //    if (obj.Name == obj.DisplayOrder.ToString())
        //    {
        //        ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name.");
        //    }
        //    if (ModelState.IsValid)
        //    {
        //        _db.Categories.Add(obj);
        //        _db.SaveChanges();
        //        TempData["success"] = "Category created successfully";
        //        return RedirectToAction("Index");
        //    }
        //    return View(obj);
        //}

        ////GET: Admin/AdminUser/Edit
        //public IActionResult Edit(int? id)
        //{
        //    if (id == null || id == 0)
        //    {
        //        return NotFound();
        //    }
        //    var categoryFromDb = _db.Categories.Find(id);
        //    //var categoryFromDbFirst = _db.Categories.FirstOrDefault(u=>u.Id==id);
        //    //var categoryFromDbSingle = _db.Categories.SingleOrDefault(u => u.Id == id);

        //    if (categoryFromDb == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(categoryFromDb);
        //}
        ////POST
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Edit(Category obj)
        //{
        //    if (obj.Name == obj.DisplayOrder.ToString())
        //    {
        //        ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name.");
        //    }
        //    if (ModelState.IsValid)
        //    {
        //        _db.Categories.Update(obj);
        //        _db.SaveChanges();
        //        TempData["success"] = "Category updated successfully";
        //        return RedirectToAction("Index");
        //    }
        //    return View(obj);
        //}

        ////GET: Admin/AdminUser/Delete
        //public IActionResult Delete(int? id)
        //{
        //    if (id == null || id == 0)
        //    {
        //        return NotFound();
        //    }
        //    var categoryFromDb = _db.Categories.Find(id);
        //    //var categoryFromDbFirst = _db.Categories.FirstOrDefault(u=>u.Id==id);
        //    //var categoryFromDbSingle = _db.Categories.SingleOrDefault(u => u.Id == id);

        //    if (categoryFromDb == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(categoryFromDb);
        //}
        ////POST
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public IActionResult DeletePOST(int? id)
        //{
        //    var obj = _db.Categories.Find(id);
        //    if (obj == null)
        //    {
        //        return NotFound();
        //    }
        //    _db.Categories.Remove(obj);
        //    _db.SaveChanges();
        //    TempData["success"] = "Category deleted successfully";
        //    return RedirectToAction("Index");
        //}

    }
}
