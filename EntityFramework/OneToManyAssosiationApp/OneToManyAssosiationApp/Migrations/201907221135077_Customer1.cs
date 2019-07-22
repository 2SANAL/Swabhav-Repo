namespace OneToManyAssosiationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Customer1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CUSTOMER",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CustomerName = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.ORDER", "Customer_Id", c => c.Guid());
            CreateIndex("dbo.ORDER", "Customer_Id");
            AddForeignKey("dbo.ORDER", "Customer_Id", "dbo.CUSTOMER", "Id");
            DropColumn("dbo.ORDER", "CustomerName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ORDER", "CustomerName", c => c.String());
            DropForeignKey("dbo.ORDER", "Customer_Id", "dbo.CUSTOMER");
            DropIndex("dbo.ORDER", new[] { "Customer_Id" });
            DropColumn("dbo.ORDER", "Customer_Id");
            DropTable("dbo.CUSTOMER");
        }
    }
}
