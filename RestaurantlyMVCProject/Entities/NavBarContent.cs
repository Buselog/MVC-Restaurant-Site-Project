using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantlyMVCProject.Entities
{
    public class NavBarContent
    {
        public IEnumerable<Notification> Notifications { get; set; }
        public IEnumerable<Messages> Messages { get; set; }
    }

}