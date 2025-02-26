using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantlyMVCProject.Entities
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string TestimonialName { get; set; }
        public string TestimonialTitle { get; set; }
        public string TestimonialDescription { get; set; }
        public string TestimonialImageUrl { get; set; }
    }
}
