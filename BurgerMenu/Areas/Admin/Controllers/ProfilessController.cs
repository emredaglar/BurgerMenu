using BurgerMenu.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurgerMenu.Areas.Admin.Controllers
{
    //[Authorize]
    public class ProfilessController : Controller
    {
        // GET: Admin/Profiless


        BurgerMenuContext context = new BurgerMenuContext();
        [HttpGet]
        public ActionResult MyProfileLists()
        {
            var UserName = Session["x"];
            var values = context.Admins.Where(x => x.UserName == UserName).FirstOrDefault();
            return View(values);
        }
        [HttpPost]
        public ActionResult MyProfileLists(BurgerMenu.Entities.Admin admin)
        {
            var UserName = Session["x"];
            var values = context.Admins.Where(x => x.UserName == UserName).FirstOrDefault();
            values.UserName = admin.UserName;
            values.Surname = admin.Surname;
            values.Name = admin.Name;
            values.Password = admin.Password;
            values.Email = admin.Email;
            context.SaveChanges();
            return RedirectToAction("Index", "Loginss");
        }

    }
}