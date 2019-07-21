using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WelcomeMvcApp.Servies;

namespace WelcomeMvcApp.Model.Student
{

    public class IndexViewModel
    {
        Authentrication a;

        public IndexViewModel()
        {
            a = new Authentrication();
            _user = a.User;
        }
        private string _user;
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

        public string User
        {
            get { return _user; }
        }
    }
}