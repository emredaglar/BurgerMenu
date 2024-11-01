using BurgerMenu.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurgerMenu.Areas.Admin.Controllers
{
    public class StatisticsController : Controller
    {
		// GET: Admin/Statistics
		BurgerMenuContext context = new BurgerMenuContext();
		public ActionResult Index()
		{
			ViewBag.canceledReservations = context.Reservations.Where(x => x.ReservationStatus == "İptal Edildi").Count();
			ViewBag.acceptedReservations = context.Reservations.Where(x => x.ReservationStatus == "Onaylandı").Count();
			ViewBag.waitReservations = context.Reservations.Where(x => x.ReservationStatus == "Onay Bekleniyor").Count();
			ViewBag.products = context.Products.Count();
			ViewBag.reservations = context.Reservations.Count();
			ViewBag.admins = context.Admins.Count();
			ViewBag.testimonials = context.Contacts.Count();
			ViewBag.deals = context.Products.Where(x => x.DealofTheDay == true).Select(y => y.ProductName).Count();
			
			ViewBag.categories = context.Categories.Count();
			ViewBag.mainDishes = context.Products.Where(x => x.CategoryId == 1).Count();
			ViewBag.minPrice = context.Products.Select(x => x.Price).Min();
			ViewBag.avgPrice = context.Products.Select(x => x.Price).Average();
			ViewBag.maxPrice = context.Products.Select(x => x.Price).Max();
			ViewBag.lastReserve = context.Reservations.OrderByDescending(x => x.ReservationId).Select(x => x.Time).FirstOrDefault();
			ViewBag.totalMessage=context.Messages.Count();
			return View();
			
		}
	}
}