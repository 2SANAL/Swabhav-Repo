namespace OneToManyAssosiationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Product1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.LINEITEM", "ProductName");
            DropColumn("dbo.LINEITEM", "UnitPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LINEITEM", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("dbo.LINEITEM", "ProductName", c => c.String());
        }
    }
}
