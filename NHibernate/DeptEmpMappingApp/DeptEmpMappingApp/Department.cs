
using System.Collections.Generic;


namespace DeptEmpMappingApp
{
  public  class Department
    {
        public virtual int Id { get; set; }
        public virtual string DepartmentName { get; set; }
        public virtual string Location { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
