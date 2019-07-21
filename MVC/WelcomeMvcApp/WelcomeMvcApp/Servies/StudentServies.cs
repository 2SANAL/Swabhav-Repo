using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WelcomeMvcApp.BusinessModel;
using WelcomeMvcApp.Model.Student;

namespace WelcomeMvcApp.Servies
{
    public class StudentServies
    {
        private static int i = 0;
        Student student1;
        private Student _student = new Student();
        private static readonly List<Student> studentsList;

        static StudentServies()
        {
            studentsList = new List<Student>();
        }
        public List<Student> Get()
        {
            return studentsList;
        }

        public int Count
        {
            get { return studentsList.Count; }
        }

        public void Add(Student student)
        {
            studentsList.Add(student);
        }
        public Student ConvertVmToStudent(AddViewModel addViewModel)
        {
            Student student = new Student();
            student.Name = addViewModel.StudentName;
            student.Cgpi = Convert.ToDouble(addViewModel.StudentGgpi);
            student.DOB = addViewModel.StudentDOB;
            student.Location = addViewModel.StudentLocation;
            student.Id = Convert.ToInt32(addViewModel.StudentRollNo);
            student.Age = DateTime.Now.Year - Convert.ToDateTime(addViewModel.StudentDOB).Year;
            return (student);
        }

        public Student ConvertVmToStudent1(EditViewModel editViewModel)
        {
            _student.Name = editViewModel.EditName;
            _student.Cgpi = Convert.ToDouble(editViewModel.EditCgpi);
            _student.DOB = editViewModel.EditDOB;
            _student.Location = editViewModel.EditLocation;
            _student.Id = Convert.ToInt32(editViewModel.EditRollNo);
            _student.Age = DateTime.Now.Year - Convert.ToDateTime(editViewModel.EditDOB).Year;

            return _student;
        }

        public Student GetstudentData(int rollNo)
        {
            Student student1 = new Student();
            foreach (var student in studentsList)
            {
                if (student.Id == rollNo)
                {
                    student1.Name = student.Name;
                    student1.Age = student.Age;
                    student1.DOB = student.DOB;
                    student1.Cgpi = student.Cgpi;
                    student1.Location = student.Location;
                    student1.Id = student.Id;
                }

            }

            return student1;
        }

        public void RemoveStudent(int rollno)
        {

            foreach (Student student in studentsList)
            {
                if (student.Id == rollno)
                {
                    student1 = student;
                }
            }

            if (student1 != null)
            {
                studentsList.Remove(student1);
            }
        }
    }
}