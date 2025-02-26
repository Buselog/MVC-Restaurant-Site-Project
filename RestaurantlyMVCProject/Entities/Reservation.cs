using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantlyMVCProject.Entities
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public string ReservationName { get; set; }
        public string ReservationEmail { get; set; }
        public string ReservationPhone { get; set; }
        public string ReservationDescription { get; set; }
        public DateTime ReservationDate { get; set; }
        public string ReservationTime { get; set; }
        public byte ReservationGuestCount { get; set; }
        public string ReservationSatatus { get; set; }


    }
}