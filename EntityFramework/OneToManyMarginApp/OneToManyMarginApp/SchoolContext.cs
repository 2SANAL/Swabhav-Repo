using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyMarginApp
{
    class SchoolContext : DbContext
    {
        public DbSet<Student2> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student2>()
                .HasRequired<Grade>(s => s.CurrentGrade)
                .WithMany(g => g.Students)
                .HasForeignKey<int>(s => s.CurrentGradeId);
        }
    }
}
