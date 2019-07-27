using FluentNHibernate.Mapping;

namespace DeptEmpMappingApp
{
    class EmployeeMapping : ClassMap<Employee>
    {
        EmployeeMapping()
        {
            Id(e => e.Id);
            Map(e => e.EName);
            Map(e => e.Salary);
            References(m => m.Department);
        }
    }
}
