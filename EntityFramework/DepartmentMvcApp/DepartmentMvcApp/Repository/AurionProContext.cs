using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DepartmentMvcApp.BusinessModel;
using System.Web;

namespace DepartmentMvcApp.Repository
{
    public class AurionProContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
    }
}