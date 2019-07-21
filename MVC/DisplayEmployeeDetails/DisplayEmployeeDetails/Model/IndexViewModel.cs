using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DisplayEmployeeDetails.BusinessModel;


namespace DisplayEmployeeDetails.Model
{
    public class IndexViewModel
    {
        public IEnumerable<Employee> EmployeList { get; set; }

        public string DName
        {
            get;
            set;
        }

        public string DNo { get; set; }
        public IEnumerable<Department> DeptList { get; set; }

    }
}