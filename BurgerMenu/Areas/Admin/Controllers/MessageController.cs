using BurgerMenu.Context;
using BurgerMenu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurgerMenu.Areas.Admin.Controllers
{
    public class MessageController : Controller
    {
        // GET: Admin/Message
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult InBox()
        {
            var UserName = Session["x"];
            var email=context.Admins.Where(x=>x.UserName == UserName).Select(x=>x.Email).FirstOrDefault();
            var values=context.Messages.Where(x=>x.ReceiverEmail==email).ToList();
            return View(values);
        }
        public ActionResult SendBox()
        {
            var UserName = Session["x"];
            var email = context.Admins.Where(x => x.UserName == UserName).Select(x => x.Email).FirstOrDefault();
            var values = context.Messages.Where(x => x.SenderEmail == email).ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message message)
        {
            var UserName = Session["x"];
            var email = context.Admins.Where(x => x.UserName == UserName).Select(x => x.Email).FirstOrDefault();
            message.SenderEmail=email;
            message.IsRead = false;
            message.SendDate = DateTime.Now;
            context.Messages.Add(message);
            context.SaveChanges();
            return RedirectToAction("SendBox","Message",new {area="Admin"});
        }
    }
}