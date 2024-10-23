using BurgerMenu.Context;
using BurgerMenu.Entities;
using System.Web.Mvc;

namespace BurgerMenu.Controllers
{
    public class ContactController : Controller
    {
        // Veritabanı context'ini başlatıyoruz.
        BurgerMenuContext context = new BurgerMenuContext();

        // GET: Contact
        [HttpGet]
        public PartialViewResult PartialContactt()
        {
            return PartialView();
        }

        // Sadece Contact tablosuna veri kaydetmek için POST işlemi.
        [HttpPost]
        public ActionResult PartialContactt(Contact contact)
        {
            // Yalnızca Contact modeline ait verileri kaydediyoruz.
            if (ModelState.IsValid)
            {
                context.Contacts.Add(contact); // Sadece Contact tablosuna ekleme yapılıyor.
                context.SaveChanges();
            }

            return PartialView(contact); // Aynı sayfaya yönlendirme.
        }
    }
}