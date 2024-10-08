using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BurgerMenu.Entities
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string CustomarName { get; set; }
        public string Commet { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}