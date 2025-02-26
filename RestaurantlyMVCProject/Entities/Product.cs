using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantlyMVCProject.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string  ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductImageUrl { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}