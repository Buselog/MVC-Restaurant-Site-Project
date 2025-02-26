namespace RestaurantlyMVCProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEventGalleryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        EventTitle = c.String(),
                        EventPriceRange = c.String(),
                        Description = c.String(),
                        EventImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.EventId);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ImagesId = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.ImagesId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Images");
            DropTable("dbo.Events");
        }
    }
}
