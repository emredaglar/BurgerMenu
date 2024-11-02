using BurgerMenu.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurgerMenu.Areas.Admin.Controllers
{
    public class ChartController : Controller
    {
		// GET: Admin/Chart
		BurgerMenuContext context = new BurgerMenuContext();

		public ActionResult Index()
		{
			return View();
		}
		public ActionResult CategoryProductChart()
		{
			// Kategori ve ürün sayısı ilişkisini alıyoruz
			var data = context.Categories
				.Where(c => c.Products.Count > 0)
				.Select(c => new
				{
					CategoryName = c.CategoryName,
					ProductCount = c.Products.Count
				})
				.ToList();
			return Json(data, JsonRequestBehavior.AllowGet);
		}

		public ActionResult MessageDateChart()
		{
			return View();
		}

		public ActionResult MessageChart()
		{
			var data = context.Messages
				.GroupBy(c => c.SenderEmail) // Mesajları gönderen kişiye göre gruplandır
				.Select(g => new
				{
					MessageName = g.Key, // SenderEmail
					MessageCount = g.Count() // Gruplandırılan mesajların sayısı
				})
		.ToList();

			return Json(data, JsonRequestBehavior.AllowGet);
		}

		public ActionResult ReservationDateChart()
		{
			return View();
		}

		public ActionResult ReservationChart()
		{
			var data = context.Reservations
	   .GroupBy(c => c.Time) // Yalnızca tarih kısmını al
	   .Select(g => new
	   {
		   // Tarih kısmını gün/ay/yıl formatında döndür
		   ReservationDate = g.Key,
		   ReservationCount = g.Count()
	   })
	   .ToList();

			return Json(data, JsonRequestBehavior.AllowGet);
		}

		public ActionResult DealofTheDaysChart()
		{
			return View();
		}

		public ActionResult DealofTheDaysCategory()
		{
			var data = context.Products
				.Where(c => c.DealofTheDay == true).GroupBy(c => c.Category.CategoryName)
				.Select(g => new
				{
					DealName = g.Key,
					DealCategory = g.Count()
				})
				.ToList();

			return Json(data, JsonRequestBehavior.AllowGet);
		}
		public ActionResult ReservationStatusChart()
		{
			var data = context.Reservations
				.GroupBy(r => r.ReservationStatus) // 'status' alanı ile grupluyoruz
				.Select(g => new
				{
					ReservationStatus = g.Key,
					ReservationCount = g.Count()
				}).ToList();
			return Json(data, JsonRequestBehavior.AllowGet);
		}
	}
}