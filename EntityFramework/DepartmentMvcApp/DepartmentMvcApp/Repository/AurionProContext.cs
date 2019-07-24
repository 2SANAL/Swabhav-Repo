using System.Data.Entity;
using DepartmentMvcApp.BusinessModel;

namespace DepartmentMvcApp.Repository
{
    public class AurionProContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Login> Logins { get; set; }
    }
}