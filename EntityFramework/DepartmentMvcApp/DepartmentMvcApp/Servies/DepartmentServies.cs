using System;
using System.Collections.Generic;
using System.Linq;
using DepartmentMvcApp.BusinessModel;
using DepartmentMvcApp.Model;

using DepartmentMvcApp.Repository;
using System.Web;

namespace DepartmentMvcApp.Servies
{
    public class DepartmentServies
    {
        private readonly DepartmentRepository _repository = new DepartmentRepository();
        public Department ConvertToDeptObj(AddViewModel addViewModel)
        {
            Department department = new Department();
            department.Id = Guid.NewGuid();
            department.DepartmentName = addViewModel.DepartmentName;
            department.Location = addViewModel.Location;
            return department;
        }

        public void AddDepartments(Department dept)
        {
            _repository.AddDept(dept);
        }

        public IQueryable<Department> GetDepatDepartments()
        {
            
            return _repository.GetDepartments();
        }

        public Department GetDeptById(Guid id)
        {
            return _repository.GetDepartmentById(id);
        }

        public void Update(EditViewModel editViewModel)
        {
            _repository.UpdateDept(editViewModel);
        }

    }
}