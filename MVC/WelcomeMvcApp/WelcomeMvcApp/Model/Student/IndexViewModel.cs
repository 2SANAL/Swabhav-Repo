using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WelcomeMvcApp.Model.Student
{
    public class IndexViewModel
    {
        public int Count
        {
            get;
            set;
        }

        public List<BusinessModel.Student> Students
        {
            get;
            set;
        }

    }
}