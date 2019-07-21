using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WelcomeMvcApp.Model.Student
{
    public class EditViewModel
    {
        public string EditName { get; set; }
        public string EditRollNo { get; set; }
        public string EditCgpi { get; set; }
        public string EditLocation { get; set; }
        public string EditDOB { get; set; }
        public string Error { get; set; }
    }
}