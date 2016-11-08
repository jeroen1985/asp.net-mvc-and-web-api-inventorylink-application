namespace InventoryLink2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelupdate4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Locations", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Products", "ProductIdExternal", c => c.String(nullable: false, maxLength: 180));
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Products", "ProductAttributeA", c => c.String(maxLength: 180));
            AlterColumn("dbo.Products", "ProductAttributeB", c => c.String(maxLength: 180));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "ProductAttributeB", c => c.String());
            AlterColumn("dbo.Products", "ProductAttributeA", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "ProductIdExternal", c => c.String(nullable: false));
            AlterColumn("dbo.Locations", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false));
        }
    }
}
