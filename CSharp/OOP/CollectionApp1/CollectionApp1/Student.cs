using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionApp1
{
    class Student
    {
        private readonly int _rollno;
        private readonly int _standared;
        private readonly string _name;

        public Student(int rollno,int standared,string name)
        {
            _rollno = rollno;
            _standared = standared;
            _name = name;
        }
       public int RollNo
        {
            get
            {
                return _rollno;
            }
        }
        public int Standared
        {
            get
            {
                return _standared;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public override bool Equals(object obj)
        {
            Student student;
            student = (Student)obj;
            if ( (student._rollno == this._rollno) && (student._standared== this._standared))
            {   
                return true;
            }
            else
            {
                return false;
            }

        }
        public override int GetHashCode()
        {
            return 1;
        }
    }
}
