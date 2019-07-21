using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WelcomeMvcApp.Model.Student;

namespace WelcomeMvcApp.Servies
{
   
    public class Authentrication
    {
        private string _username = "akash";

        private string _password = "123";
        public bool Authenticate(LoginViewModel loginViewModel)
        {
            if (loginViewModel.Username.Equals(_username) && loginViewModel.Password.Equals(_password))
            {
                return true;
            }

            return false;
        }

        public string User
        {
            get { return _username; }
        }
    }
}