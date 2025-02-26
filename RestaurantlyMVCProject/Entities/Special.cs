using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantlyMVCProject.Entities
{
    public class Special
    {
        public int SpecialId { get; set; }
        public string SpecialName { get; set; }
        public string SpecialShortDescription { get; set; }
        public string SpecialFullDescription { get; set; }
        public string SpecialImageUrl { get; set; }
    }
}