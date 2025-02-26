using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantlyMVCProject.Entities
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventTitle { get; set; }
        public string EventPriceRange { get; set; }
        public string Description { get; set; }
        public string EventImageUrl { get; set; }

    }
}