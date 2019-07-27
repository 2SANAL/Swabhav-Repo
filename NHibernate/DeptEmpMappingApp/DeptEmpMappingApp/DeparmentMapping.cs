
using FluentNHibernate.Mapping;


namespace DeptEmpMappingApp
{
    class DeparmentMapping : ClassMap<Department>
    {
        DeparmentMapping()
        {
            Id(e => e.Id);
            Map(e => e.DepartmentName);
            Map(e => e.Location);
            HasMany(m => m.Employees).Cascade.All();
        }
    }
}
