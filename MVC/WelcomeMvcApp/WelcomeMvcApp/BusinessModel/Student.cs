using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WelcomeMvcApp.BusinessModel
{
    public class Student
    {
        public string Name { get; set; }
        public int RollNo { get; set; }
        public int Age { get; set; }
        public double Cgpi { get; set; }
        public string Location { get; set; }
        public string DOB { get; set; }
    }
}