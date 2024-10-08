using BurgerMenu.Context;
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
        BurgerMenuContext context=new BurgerMenuContext();
        public ActionResult CategoryList()
        {
            var values=context.Categories.ToList();
            return View(values);
        }
    }
}