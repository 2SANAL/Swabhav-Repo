using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace EmployeeFluentApp
{
    class EmployeeMapping : ClassMap<Employee>
    {
        EmployeeMapping()
        {
            Id(e => e.Id);
            Map(e => e.FirstName);
            Map(e => e.LastName);
            Table("Employee");
        }
    }
}
