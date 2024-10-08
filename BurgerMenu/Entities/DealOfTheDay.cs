using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BurgerMenu.Entities
{
    public class DealOfTheDay
    {
        public int DealOfTheDayId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}