using System;
using System.Linq;
using DepartmentMvcApp.BusinessModel;
using DepartmentMvcApp.Repository;
using DepartmentMvcApp.Model;

namespace DepartmentMvcApp.Servies
{
    public class EmployeeServies
    {
        private readonly DepartmentRepository _repository = new DepartmentRepository();


        public Employee GetEployeeObj(AddEmployeeViewModel addEmployeeViewModel)
        {
            Employee employee = new Employee();

            employee.Comm = Convert.ToDouble(addEmployeeViewModel.Comm);
            employee.DateOfJoin = addEmployeeViewModel.DateOfJoin;
            employee.EmployeeName = addEmployeeViewModel.EmployeeName;
            employee.Job = addEmployeeViewModel.Job;
            employee.Salary = Convert.ToDouble(addEmployeeViewModel.Salary);
            employee.Department = _repository.GetDepartmentById(Guid.Parse(addEmployeeViewModel.DeptId));

            return employee;
        }
        public void AddEmployee(Employee employee)
        {
            _repository.AddEmployee(employee);
        }

        public IQueryable<Employee> GetEmployees()
        {
            return _repository.GetEmployees();
        }

        public IQueryable<Employee> GetEmployeesByDeptId(Guid id)
        {
            var employees = _repository.GetEmployeesByDeptId(id);
            return employees;
        }
        public EditEmployeeViewModel GetEmployeeById(Guid id)
        {
            var employee = _repository.GetEmployeeById(id);
            EditEmployeeViewModel edit = new EditEmployeeViewModel();
            edit.Salary = Convert.ToString(employee.Salary);
            edit.EmployeeName = (employee.EmployeeName);
            edit.Comm = Convert.ToString(employee.Comm);
            edit.DateOfJoin = (employee.DateOfJoin);
            edit.Job = (employee.Job);
            edit.Id = employee.Id;
            return edit;
        }

        public void UpdateEmp(EditEmployeeViewModel editEmployeeViewModel)
        {
            _repository.UpdateEmp(editEmployeeViewModel);
        }
    }
}