using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DepartmentMvcApp.BusinessModel;

namespace DepartmentMvcApp.Model
{
    public class AddEmployeeViewModel
    {
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string DateOfJoin { get; set; }
        [Required]
        public string Salary { get; set; }
        [Required]
        public string JOB { get; set; }
        [Required]
        public string COMM { get; set; }
        [Required]
        public string DeptId { get; set; }
        public List<Department> Departments { get; set; }

    }
}