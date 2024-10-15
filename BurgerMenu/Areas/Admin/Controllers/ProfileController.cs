﻿using BurgerMenu.Context;
using BurgerMenu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurgerMenu.Controllers
{
   // [Authorize]
    public class ProfileController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        // GET: Profile
        public ActionResult MyProfileList()
        {
            var userName = Session["x"];
            var values = context.Admins.Where(x => x.UserName == userName).FirstOrDefault();
            return View(values);
        }
        [HttpPost]
        public ActionResult MyProfileList(BurgerMenu.Entities.Admin admin)
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