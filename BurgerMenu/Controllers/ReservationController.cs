using BurgerMenu.Context;
using BurgerMenu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurgerMenu.Controllers
{
    public class ReservationController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        // GET: Reservation
        [HttpGet]
        public PartialViewResult PartialReservationn()
        {
            return PartialView();
        }
        [HttpPost]
        [Route("Contact/PartialReservationn")]
        public PartialViewResult PartialReservationn(Reservation reservation)
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