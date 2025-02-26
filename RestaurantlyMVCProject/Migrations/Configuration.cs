namespace RestaurantlyMVCProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    //Bu dosya, yaptığımız değişiklikleri SQL komutları olarak tanımlar.

    internal sealed class Configuration : DbMigrationsConfiguration<RestaurantlyMVCProject.Context.RestaurantlyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(RestaurantlyMVCProject.Context.RestaurantlyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
