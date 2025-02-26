using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantlyMVCProject.Entities
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public string Title { get; set; }
        public DateTime SendTime { get; set; }
        public string Icon { get; set; }
        public string IconColor { get; set; }
        public bool IsRead { get; set; }

    }
}