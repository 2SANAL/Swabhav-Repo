using System;
using System.Collections.Generic;

namespace EngineeringCollegeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            College college = new College();
            AddPerson(college);
            DisplayDetails(college);
        }

        public static void AddPerson(College college)
        {
            college.AddProfessor("VIT", "Mumbai", new Professor(101, "Mahim", "7/5/1974 7:10:24 AM", 25000));
            college.AddProfessor("VIT", "Mumbai", new Professor(102, "Mahim", "17/10/1998 7:10:24 AM", 25000));
            college.AddStudent("VIT", "Mumbai",new Student( 001, "Mahim", "6/11/2010 7:10:24 AM", Branches.COMPUTER_ENGINEERING));   
            college.AddStudent("VIT", "Mumbai",new Student( 002, "Mahim", "3/1/1990 7:10:24 AM", Branches.CHEMICAL_ENGINEERING));
        }

        public static void DisplayDetails(College college)
        {
            List<Student> student = new List<Student>();
            List<Professor> professor = new List<Professor>();
            student = college.StudentList;
            professor = college.ProfessorList;

            Console.WriteLine("\n---Student Details---");
            foreach (Student studentobj in student)
            {
                CommanDetails(studentobj, college);
                Console.WriteLine(" Branch          :" + studentobj.Baranch);
                Console.WriteLine("\n");
            }
            
            Console.WriteLine("\n----Professor Details----");
            foreach (Professor professorobj in professor)
            {
                CommanDetails(professorobj, college);
                Console.WriteLine(" Salary          :" + professorobj.Salary);
                Console.WriteLine(" Bonus           :" + professorobj.CalaculateSalary());
                Console.WriteLine("\n");
            }

            Console.WriteLine("Toala Number of Student    :"+ college.NumberOfStudent);
            Console.WriteLine("Toala Number of Professor  :"+ college.NumberOfProfessor);
            Console.WriteLine();
        }
        public static void CommanDetails(Person person, College college)
        {
            Console.WriteLine(" ID              :" + person.Id);
            Console.WriteLine(" Addres          :" + person.Address);
            Console.WriteLine(" Date of Barth   :" + person.DateOfBarth);
            Console.WriteLine(" College Name    :" + college.CollegeName);
            Console.WriteLine(" College Location:" + college.Location);
            Console.WriteLine(" Age              :"+person.Age);
        }
    }
}
