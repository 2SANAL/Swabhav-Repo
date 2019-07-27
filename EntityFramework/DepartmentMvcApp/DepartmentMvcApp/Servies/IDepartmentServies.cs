using System;
using System.Linq;
using DepartmentMvcApp.BusinessModel;
using DepartmentMvcApp.Model;

namespace DepartmentMvcApp.Servies
{
    public interface IDepartmentServies
    {
        Department ConvertToDeptObj(AddViewModel addViewModel);
        void AddDepartments(Department dept);
        IQueryable<Department> GetDepatDepartments();
        Department GetDeptById(Guid id);
        void Update(EditViewModel editViewModel);
    }
}