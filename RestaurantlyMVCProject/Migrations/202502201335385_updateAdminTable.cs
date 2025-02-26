namespace RestaurantlyMVCProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateAdminTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "Name", c => c.String());
            AddColumn("dbo.Admins", "Surname", c => c.String());
            AddColumn("dbo.Admins", "Email", c => c.String());
            AddColumn("dbo.Admins", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Admins", "ImageUrl");
            DropColumn("dbo.Admins", "Email");
            DropColumn("dbo.Admins", "Surname");
            DropColumn("dbo.Admins", "Name");
        }
    }
}
