using BurgerMenu.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurgerMenu.Areas.Admin.Controllers
{
    //[Authorize]
    public class ProfilesController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult MyProfilList()
        {
            var userName = Session["x"];
            var values = context.Admins.Where(x => x.UserName == userName).FirstOrDefault();
            return View(values);
        }
        [HttpPost]
        public ActionResult MyProfilList(BurgerMenu.Entities.Admin admin)
        {
            var userName = Session["x"];
            var values = context.Admins.Where(x => x.UserName == userName).FirstOrDefault();
            values.UserName = admin.UserName;
            values.Surname = admin.Surname;
            values.Name = admin.Name;
            values.Password = admin.Password;
            values.Email = admin.Email;
            context.SaveChanges();
            return RedirectToAction("Index", "Login");
        }
    }
}