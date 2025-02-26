using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantlyMVCProject.Entities
{
    public class Messages
    {
        public int MessagesId { get; set; }
        public string SenderName { get; set; }
        public DateTime SendDate { get; set; }
        public string Message { get; set; }
        public string Icon { get; set; }
        public string IconColor { get; set; }
        public bool IsRead { get; set; }

    }
}