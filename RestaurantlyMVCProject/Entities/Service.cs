using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantlyMVCProject.Entities
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string ServiceTitle { get; set; }
        public string ServiceDescription { get; set; }
    }
}