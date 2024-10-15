using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurgerMenu.Controllers
{
    public class ErrorPageControllerController : Controller
    {
        // GET: ErrorPageController
        public ActionResult Page404()
        {
            return View();
        }
    }
}