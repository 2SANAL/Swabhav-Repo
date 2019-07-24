namespace DepartmentMvcApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Emp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EMPLOYEE",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        EmployeeName = c.String(),
                        DateOfJoin = c.String(),
                        Salary = c.Double(nullable: false),
                        JOB = c.String(),
                        COMM = c.Double(nullable: false),
                        Department_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DEPARTMENT", t => t.Department_Id)
                .Index(t => t.Department_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EMPLOYEE", "Department_Id", "dbo.DEPARTMENT");
            DropIndex("dbo.EMPLOYEE", new[] { "Department_Id" });
            DropTable("dbo.EMPLOYEE");
        }
    }
}
