namespace RestaurantlyMVCProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMessagesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessagesId = c.Int(nullable: false, identity: true),
                        SenderName = c.String(),
                        SendDate = c.DateTime(nullable: false),
                        Message = c.String(),
                        Icon = c.String(),
                        IconColor = c.String(),
                    })
                .PrimaryKey(t => t.MessagesId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Messages");
        }
    }
}
