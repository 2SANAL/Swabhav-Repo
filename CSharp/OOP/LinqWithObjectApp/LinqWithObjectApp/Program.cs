using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithObjectApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student() { FirstName = "Akash", LastName = "Jaiswal", Cgpi = 8.9, Location = "Mumbai" };
            var student2 = new Student() { FirstName = "Dhruv", LastName = "Ballikar", Cgpi = 9.9, Location = "Mumbai" };
            var student3 = new Student() { FirstName = "Sanal", LastName = "Dhamanse", Cgpi = 7.9, Location = "Raigad" };
            var student4 = new Student() { FirstName = "Dipesh", LastName = "Ballikar", Cgpi = 5.9, Location = "Thane" };

            IEnumerable<Student> studentsDetails = new List<Student>() { student1, student2, student3, student4 };

            IEnumerable<Student> studentInMumbai =
                studentsDetails
                    .Where((stud) => stud.Location.Equals("Mumbai"));

            foreach (Student student in studentInMumbai)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.Cgpi + " " +
                                  student.Location);
            }
            var studentsLocatioAndName =
                studentsDetails
                    .Select((s) => new { s.Location, s.FirstName });


            foreach (var LocationName in studentsLocatioAndName)
            {
                Console.Write(LocationName.FirstName + " ");
                Console.WriteLine(LocationName.Location);
            }

            IList<Student> teenStudents = (from s in studentsDetails
                                               where s.Location.Equals("Mumbai")
                                               select s).ToList();
        }
    }
}
