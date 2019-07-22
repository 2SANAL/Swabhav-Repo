namespace OneToManyAssosiationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Product : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PRODUCT",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ProductName = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.LINEITEM", "Product_Id", c => c.Guid());
            CreateIndex("dbo.LINEITEM", "Product_Id");
            AddForeignKey("dbo.LINEITEM", "Product_Id", "dbo.PRODUCT", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LINEITEM", "Product_Id", "dbo.PRODUCT");
            DropIndex("dbo.LINEITEM", new[] { "Product_Id" });
            DropColumn("dbo.LINEITEM", "Product_Id");
            DropTable("dbo.PRODUCT");
        }
    }
}
