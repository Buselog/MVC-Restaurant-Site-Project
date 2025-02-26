using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantlyMVCProject.Entities
{
    public class Chef
    {
        public int  ChefId { get; set; }
        public string ChefName { get; set; }
        public string ChefTitle { get; set; }
        public string ChefImageUrl { get; set; }

    }

}