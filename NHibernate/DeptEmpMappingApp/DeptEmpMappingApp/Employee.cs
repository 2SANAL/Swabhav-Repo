using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeptEmpMappingApp
{
 public class Employee
    {
        public virtual int Id { get; set; }
        public virtual string EName { get; set; }
        public virtual double Salary { get; set; }
        public virtual Department Department { get; set; }
    }
}
