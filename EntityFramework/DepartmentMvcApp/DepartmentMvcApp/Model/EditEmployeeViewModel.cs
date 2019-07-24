using System;
using System.ComponentModel.DataAnnotations;

namespace DepartmentMvcApp.Model
{
    public class EditEmployeeViewModel
    {
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string DateOfJoin { get; set; }
        [Required]
        public string Salary { get; set; }
        [Required]
        public string Job { get; set; }
        [Required]
        public string Comm { get; set; }
        [Required]
        public string DeptId { get; set; }
        public Guid Id { get; set; }
    }
}