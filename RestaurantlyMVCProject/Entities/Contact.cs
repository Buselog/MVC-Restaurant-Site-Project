using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantlyMVCProject.Entities
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactSubject { get; set; }
        public string ContactMessage { get; set; }
        public DateTime ContactSendDate { get; set; }
        public bool ContactIsRead { get; set; }

    }
}