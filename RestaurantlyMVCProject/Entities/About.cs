using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantlyMVCProject.Entities
{
    public class About
    {
        public int AboutId { get; set; }
        public string AboutTitle { get; set; }
        public string AboutSubtitle { get; set; }
        public string AboutImageUrl { get; set; }
    }
}