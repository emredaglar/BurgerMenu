using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BurgerMenu.Entities
{
    public class About
    {

        public int AboutId { get; set; }
        public string About1 { get; set; }
        public string About2 { get; set; }

        public string Subtitle { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string ImageUrl { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string MapLocation { get; set; }
    }
}