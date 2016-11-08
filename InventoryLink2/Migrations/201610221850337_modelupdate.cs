namespace InventoryLink2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Locations", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "ProductIdExternal", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "ProductAttribute1", c => c.Int());
            AlterColumn("dbo.Products", "ProductAttribute2", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "ProductAttribute2", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "ProductAttribute1", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "Name", c => c.String());
            AlterColumn("dbo.Products", "ProductIdExternal", c => c.Int(nullable: false));
            AlterColumn("dbo.Locations", "Name", c => c.String());
        }
    }
}
