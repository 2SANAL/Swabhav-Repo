using System.Collections.Generic;
using DepartmentMvcApp.BusinessModel;

namespace DepartmentMvcApp.Model
{
    public class EmployeeViewModel
    {
        public List<Employee> Employees { get; set; }
        public int Count { get; set; }
    }
}