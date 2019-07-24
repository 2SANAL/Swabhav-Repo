using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentMvcApp.BusinessModel
{
    [Table("EMPLOYEE")]
    public class Employee : Entity
    {
        public string EmployeeName { get; set; }
        public string DateOfJoin { get; set; }
        public double Salary { get; set; }
        public string Job { get; set; }
        public double Comm { get; set; }
        public virtual Department Department { get; set; }
    }
}