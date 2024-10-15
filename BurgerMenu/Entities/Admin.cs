using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BurgerMenu.Entities
{
    public class Admin
    {
        public int AdminID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}