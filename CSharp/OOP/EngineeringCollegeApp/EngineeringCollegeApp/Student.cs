using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EngineeringCollegeApp
{
    class Student:Person
    {
        private string _branch;
        ConvertToString convertstring = new ConvertToString();

        public Student(int id,string address, string dateOfBarth, Branches branch) : base(id,address, dateOfBarth)
        {
            string branchstring = convertstring.StringConvertor(branch);
            _branch = branchstring;
        }
        
        public string Baranch
        {
            get
            {
                return _branch;
            }
        }

    }
}
