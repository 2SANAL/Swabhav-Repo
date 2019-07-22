using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyAssosiationApp
{
    public class SwabhavDBContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<LineItem> LineItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
