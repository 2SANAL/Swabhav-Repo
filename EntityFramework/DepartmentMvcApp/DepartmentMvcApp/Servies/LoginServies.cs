using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using  DepartmentMvcApp.Repository;
using DepartmentMvcApp.Model;


namespace DepartmentMvcApp.Servies
{
    public class LoginServies
    {
        private readonly DepartmentRepository _repository=new DepartmentRepository();

        public bool IsValidUser(LoginViewModel loginViewModel)
        {
            return _repository.IsValidUser(loginViewModel);
        }

    }
}