using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WelcomeMvcApp.BusinessModel;

namespace WelcomeMvcApp.Model.DisplayEmp
{
    public class DisplayEmpViewModel
    {
        public IEnumerable<Employee> EmployeList { get; set; }
        public IEnumerable<Department> DeptList { get; set; }
        public int DepaTNO { get; set; }
        
    }
}