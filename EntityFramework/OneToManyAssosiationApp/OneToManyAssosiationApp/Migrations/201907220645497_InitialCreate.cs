namespace OneToManyAssosiationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ORDER",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Date = c.String(),
                        CustomerName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LINEITEM",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Quantity = c.Int(nullable: false),
                        ProductName = c.String(),
                        UnitPrice = c.Double(nullable: false),
                        Order_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ORDER", t => t.Order_Id)
                .Index(t => t.Order_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LINEITEM", "Order_Id", "dbo.ORDER");
            DropIndex("dbo.LINEITEM", new[] { "Order_Id" });
            DropTable("dbo.LINEITEM");
            DropTable("dbo.ORDER");
        }
    }
}
