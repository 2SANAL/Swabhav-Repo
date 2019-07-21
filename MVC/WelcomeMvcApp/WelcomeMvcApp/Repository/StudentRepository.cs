using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WelcomeMvcApp.Repository;
using WelcomeMvcApp.BusinessModel;
using System.Data.Entity;

namespace WelcomeMvcApp.Repository
{
    public class StudentRepository
    {
        private AurionProEFContext db = new AurionProEFContext();

        public void Add(Student student)
        {
            db.students.Add(student);
            db.SaveChanges();
        }

        public List<Student> GetStudents()
        {
            var studentList = from d in db.students
                              orderby d.Name
                              select d;
            return studentList.ToList();
        }

        public int Count
        {
            get { return db.students.Count(); }
        }
        public Student GetStudent(int id)
        {
            Student getStudent = new Student();

            var student = from s in db.students
                          where s.Id == id
                          select new
                          {
                              RollNo = s.Id,
                              s.Age,
                              s.Cgpi,
                              s.DOB,
                              s.Location,
                              s.Name
                          };

            foreach (var s in student)
            {
                getStudent.Id = s.RollNo;
                getStudent.Age = s.Age;
                getStudent.Cgpi = s.Cgpi;
                getStudent.DOB = s.DOB;
                getStudent.Location = s.Location;
                getStudent.Name = s.Name;
            }

            return getStudent;
        }

        public void Update(int id, Student student)
        {
            Student u = db.students.Single(s => s.Id == id);

            u.Cgpi = student.Cgpi;
            u.Age = student.Age;
            u.DOB = student.DOB;
            u.Name = student.Name;
            u.Location = student.Location;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var student = (from stud in db.students
                           where stud.Id == id
                           select stud).Single();
            db.students.Remove(student);
            db.SaveChanges();
        }
    }
}