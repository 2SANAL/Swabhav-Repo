using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentMvcApp.BusinessModel
{
    [Table("EMPLOYEE")]
    public class Employee : Entity
    {
        public string EmployeeName { get; set; }
        public string DateOfJoin { get; set; }
        public double Salary { get; set; }
        public string JOB { get; set; }
        public double COMM { get; set; }
        public virtual Department Department { get; set; }
    }
}