using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace EntityApp
{
    class Program
    {
        private static SwabhavEFDBContext db = new SwabhavEFDBContext();
        public static void Main(string[] args)
        {
        //    Update();
            DifferenceBetIenumrableAndIqurable();

        }

    private static void InsertStudent()
        {
            var s1 = new Student()
            {
                Id = Guid.NewGuid(),
                Name = "Akash",
                Cgpi = "8.6",
                Location = "Mumbai"
            };
            var s2 = new Student()
            {
                Id = Guid.NewGuid(),
                Name = "Dhruv",
                Cgpi = "9.6",
                Location = "MiraRode"
            };
            var s3 = new Student()
            {
                Id = Guid.NewGuid(),
                Name = "Sanal",
                Cgpi = "9.8",
                Location = "Raigad"
            };

            db.Students.Add(s1);
            db.Students.Add(s2);
            db.Students.Add(s3);
            db.SaveChanges();
        }
        private static void Update()
        {
            var u = db.Students.First(i => i.Name == "Sanal");
            u.Cgpi = "6.5";
            db.SaveChanges();

        }

        private static void Delete()
        {
            var delete = db.Students.First(i => i.Name == "Sanal");

            db.SaveChanges();
        }

        private static void DifferenceBetIenumrableAndIqurable()
        {
            IQueryable<Student> result = db.Students.Where((m) => m.Name.Contains("a"));

        //    var list = result.Take(3).ToList();

           // var name = db.Students.Select(m => m.Name.Split('a')[0]);

        }
    }
}
