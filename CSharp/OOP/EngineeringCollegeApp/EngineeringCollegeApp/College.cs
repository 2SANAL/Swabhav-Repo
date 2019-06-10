using System.Collections.Generic;

namespace EngineeringCollegeApp
{
    class College
    {
        private string _collegename;
        private string _location;
        private List<Student> _studentlist;
        private List<Professor> _profressorlist;

        public College()
        {
            _studentlist = new List<Student>();
            _profressorlist = new List<Professor>();
        }

        public void AddStudent(string collegename, string location, Student studentobj)
        {
            _collegename = collegename;
            _location = location;
            _studentlist.Add(studentobj);
        }

        public void AddProfessor(string collegename, string location, Professor professorobj)
        {
            _collegename = collegename;
            _location = location;
            _profressorlist.Add(professorobj);
        }

        public string CollegeName
        {
            get
            {
                return _collegename;
            }
        }

        public string Location
        {
            get
            {
                return _location;
            }
        }

        public int NumberOfStudent
        {
            get
            {
                return _studentlist.Count;
            }
        }

        public int NumberOfProfessor
        {
            get
            {
                return _profressorlist.Count;
            }
        }

        public List<Professor> ProfessorList
        {
            get
            {
                return _profressorlist;
            }
        }

        public List<Student> StudentList
        {
            get
            {
                return _studentlist;
            }
        }

    }
}
