namespace BaiThiT2012E.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Category_CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "Category_CategoryId" });
            DropColumn("dbo.Products", "CategoryId");
            RenameColumn(table: "dbo.Products", name: "Category_CategoryId", newName: "CategoryId");
            AlterColumn("dbo.Products", "SupplierId", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "CategoryId", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "QuantityPerUnit", c => c.Double(nullable: false));
            AlterColumn("dbo.Products", "UnitPrice", c => c.Double(nullable: false));
            AlterColumn("dbo.Products", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "CategoryId");
            AddForeignKey("dbo.Products", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryId" });
            AlterColumn("dbo.Products", "CategoryId", c => c.Int());
            AlterColumn("dbo.Products", "UnitPrice", c => c.String());
            AlterColumn("dbo.Products", "QuantityPerUnit", c => c.String());
            AlterColumn("dbo.Products", "CategoryId", c => c.String());
            AlterColumn("dbo.Products", "SupplierId", c => c.String());
            RenameColumn(table: "dbo.Products", name: "CategoryId", newName: "Category_CategoryId");
            AddColumn("dbo.Products", "CategoryId", c => c.String());
            CreateIndex("dbo.Products", "Category_CategoryId");
            AddForeignKey("dbo.Products", "Category_CategoryId", "dbo.Categories", "CategoryId");
        }
    }
}
