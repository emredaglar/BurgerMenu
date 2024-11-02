using BurgerMenu.Context;
using BurgerMenu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurgerMenu.Controllers
{
    public class RegistersController : Controller
    {
		// GET: Registers
		BurgerMenuContext context = new BurgerMenuContext();
		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Index(Admin admin)
		{
			context.Admins.Add(admin);
			context.SaveChanges();
			return RedirectToAction("Index", "Loginss");
		}
	}
}