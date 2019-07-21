using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WelcomeMvcApp.BusinessModel;
using System.Web;

namespace WelcomeMvcApp.Repository
{
    public class AurionProEFContext : DbContext
    {
        public DbSet<Student> students { get; set; }
    }
}
