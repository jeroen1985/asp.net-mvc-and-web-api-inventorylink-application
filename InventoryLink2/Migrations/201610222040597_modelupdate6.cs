namespace InventoryLink2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelupdate6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Stock", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Stock", c => c.Int());
        }
    }
}
