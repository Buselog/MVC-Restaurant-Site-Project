namespace RestaurantlyMVCProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNotificationTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        NotificationId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        SendTime = c.DateTime(nullable: false),
                        Icon = c.String(),
                        IconColor = c.String(),
                        IsRead = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.NotificationId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Notifications");
        }
    }
}
