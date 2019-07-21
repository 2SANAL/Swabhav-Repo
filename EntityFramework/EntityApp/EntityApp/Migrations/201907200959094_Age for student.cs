namespace EntityApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ageforstudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.STUDENT", "Age", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.STUDENT", "Age");
        }
    }
}
