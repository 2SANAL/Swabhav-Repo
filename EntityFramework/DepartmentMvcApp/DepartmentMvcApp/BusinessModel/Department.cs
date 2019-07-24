using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentMvcApp.BusinessModel
{
    [Table("DEPARTMENT")]
    public class Department : Entity
    {
        public string DepartmentName { get; set; }
        public string Location { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}