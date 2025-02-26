using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantlyMVCProject.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual List<Product> Products { get; set; }

        //Eğer virtual eklenirse, Products koleksiyonu sadece erişildiğinde veritabanından çekilir.
        //Böylece performans açısından gereksiz sorguların önüne geçilmiş olur.

    }
}