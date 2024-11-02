using BurgerMenu.Context;
using BurgerMenu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace BurgerMenu.Areas.Admin.Controllers
{
    public class ReservationController : Controller
    {
        // GET: Admin/Reservation
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult ReservationList()
        {
            var values = context.Reservations.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult DetailReservation(int id)
        {
            var value = context.Reservations.Where(x => x.ReservationId == id).FirstOrDefault();
            return View(value);
        }

        [HttpPost]
        public ActionResult DetailReservation(Reservation reservation)
        {
            var values = context.Reservations.Find(reservation.ReservationId);
            values.Name = reservation.Name;
            values.Surname = reservation.Surname;
            values.Email = reservation.Email;
            values.Phone = reservation.Phone;
            values.PeopleCount = reservation.PeopleCount;
            values.ReservationDate = reservation.ReservationDate;
            values.Time = reservation.Time;
            values.Message = reservation.Message;
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }


        public ActionResult StatusChangeToConfirm(int id)
        {
            var value = context.Reservations.Where(x => x.ReservationId == id).FirstOrDefault();
            value.ReservationStatus = "Onaylandı";
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }

        public ActionResult StatusChangeToCancel(int id)
        {
            var value = context.Reservations.Where(x => x.ReservationId == id).FirstOrDefault();
            value.ReservationStatus = "İptal Edildi";
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }

        public ActionResult StatusChangeToWait(int id)
        {
            var value = context.Reservations.Where(x => x.ReservationId == id).FirstOrDefault();
            value.ReservationStatus = "Onay Bekleniyor";
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }

        public ActionResult StatusChangeToCame(int id)
        {
            var value = context.Reservations.Where(x => x.ReservationId == id).FirstOrDefault();
            value.ReservationStatus = "Müşteri Gelmedi";
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }
		[HttpGet]
		public PartialViewResult ReservationModal()
		{
			return PartialView();
		}
		[HttpPost]
		//[Route("Reservation/PartialReservationn")]
		public PartialViewResult ReservationModal(Reservation reservation)
		{

			reservation.ReservationStatus = "Onay Bekleniyor";
			//reservation.ReservationDate = DateTime.Now;
			//reservation.PeopleCount = 2;
			context.Reservations.Add(reservation);
			context.SaveChanges();
			return PartialView();
		}
	}
}