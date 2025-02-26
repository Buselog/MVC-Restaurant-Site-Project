using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using RestaurantlyMVCProject.Entities;

namespace RestaurantlyMVCProject.Context
{
    public class RestaurantlyContext : DbContext
    {
        public DbSet<Feature> Tbl_Feature { get; set; }
        public DbSet<About> Tbl_About { get; set; }
        public DbSet<Address> Tbl_Address { get; set; }
        public DbSet<Category> Tbl_Category { get; set; }
        public DbSet<Chef> Tbl_Chef { get; set; }
        public DbSet<Contact> Tbl_Contact { get; set; }
        public DbSet<Product> Tbl_Product { get; set; }
        public DbSet<Reservation> Tbl_Reservation { get; set; }
        public DbSet<Service> Tbl_Service { get; set; }
        public DbSet<Special> Tbl_Special { get; set; }
        public DbSet<Testimonial> Tbl_Testimonial { get; set; }
        public DbSet<Admin> Tbl_Admin { get; set; }
        public DbSet<Notification> Tbl_Notification { get; set; }
        public DbSet<Event> Tbl_Event { get; set; }
        public DbSet<Images> Tbl_Images { get; set; }
        public DbSet<Messages> Tbl_Messages { get; set; }

    }

}
