using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantlyMVCProject.Entities
{
    public class Address
    {
        public int AddressId { get; set; }
        public string AddressLocation { get; set; }
        public string  AddressOpenHours { get; set; }
        public string AddressEmail { get; set; }
        public string AddressCall { get; set; }
    }
}
