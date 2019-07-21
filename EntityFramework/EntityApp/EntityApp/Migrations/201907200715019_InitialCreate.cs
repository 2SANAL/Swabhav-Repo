namespace EntityApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.STUDENT",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        CGPI = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.STUDENT");
        }
    }
}
