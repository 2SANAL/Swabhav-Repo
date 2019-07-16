using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WelcomeMvcApp.BusinessModel;
namespace WelcomeMvcApp.Servies
{
    public class StudentServies
    {
        List<Student> students = new List<Student>();

        public List<Student> Get()
        {
            students.Add(new Student()
            {
                Name = "Akash",
                RollNo = 1,
                Age = 20,
                Location = "Mumabi",
                Cgpi = 7.5,
                DOB = "13-02-1990"
            });
            students.Add(new Student()
            {
                Name = "Dhruv",
                RollNo = 2,
                Age = 20,
                Location = "MiraRoad",
                Cgpi = 8.5,
                DOB = "13-02-1996"
            });
            students.Add(new Student()
            {
                Name = "Sanal   ",
                RollNo = 3,
                Age = 20,
                Location = "Raigad",
                Cgpi = 8.5,
                DOB = "13-02-1998"
            });
            students.Add(new Student()
            {
                Name = "Dipesh",
                RollNo = 4,
                Age = 20,
                Location = "Thane",
                Cgpi = 9.5,
                DOB = "13-02-1999"
            });
            return students;
        }

        public int Count
        {
            get { return students.Count; }
        }

    }
}