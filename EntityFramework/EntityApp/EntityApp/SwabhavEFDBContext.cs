using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace EntityApp
{
    class SwabhavEFDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
 