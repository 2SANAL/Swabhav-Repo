using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WelcomeMvcApp.Model.Student
{
    public class AddViewModel
    {
        public string StudentName { get; set; }
        public string StudentDOB { get; set; }
        public string StudentLocation { get; set; }
        public string StudentGgpi { get; set; }
        public string StudentRollNo { get; set; }
        public  string Error { get; set; }
    }
}