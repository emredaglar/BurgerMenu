using BurgerMenu.Context;
using BurgerMenu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurgerMenu.Controllers
{
    public class Default1Controller : Controller
    {
        BurgerMenuContext context=new BurgerMenuContext();
        public ActionResult Index()
        {
            ViewBag.subtitle=context.Abouts.Select(x=>x.Subtitle).FirstOrDefault();
            return View();
        }

        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            
            contact.IsRead = false;
            context.Contacts.Add(contact);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialAbout()
        {
            ViewBag.hakkimizda1 = context.Abouts.Select(x=>x.About1).FirstOrDefault();
            ViewBag.hakkimizda2 = context.Abouts.Select(x=>x.About2).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult TodaysOffer()
        {
            var values=context.Products.Where(x=>x.DealofTheDay==true).ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialMenu()
        {
            var values=context.Products.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialCategory()
        {
            var values=context.Categories.Take(6).ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialGallery()
        {
            var values = context.Products.Take(6).ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialFooter()
        {
            ViewBag.hakkimizda1 = context.Abouts.Select(x => x.About1).FirstOrDefault();
           

            return PartialView();
        }
        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }
       
        
        public PartialViewResult PartialMap()
        {
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult PartialReservation()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialReservation(Reservation reservation)
        {
            reservation.ReservationStatus = "Onay Bekleniyor";
            reservation.ReservationDate = DateTime.Now;
            context.Reservations.Add(reservation);
            context.SaveChanges();
            return PartialView();
        }
        public PartialViewResult PartialContact()
        {
            var values = context.Abouts.ToList();
            return PartialView(values);
        }
    }
}