using BurgerMenu.Context;
using BurgerMenu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurgerMenu.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Admin/Category
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult CategoryList()
        {
            var values = context.Categories.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCategory(Category category)
        {
            var values = context.Categories.Add(category);
            context.SaveChanges();
            return RedirectToAction("CategoryList");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var values = context.Categories.Where(c => c.CategoryId == id).FirstOrDefault();
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            var values = context.Categories.Where(c => c.CategoryId == category.CategoryId).FirstOrDefault();
            values.CategoryName = category.CategoryName;
            context.SaveChanges();
            return RedirectToAction("CategoryList");
        }
        public ActionResult DeleteCategory(int id)
        {
            var values = context.Categories.Where(c => c.CategoryId == id).FirstOrDefault();
            context.Categories.Remove(values);
            context.SaveChanges();
            return RedirectToAction("CategoryList");

        }
		public ActionResult CategoryProducts(int id)
		{
			var value = context.Products.Where(y => y.CategoryId == id).ToList();
			return View(value);
		}
	}
}