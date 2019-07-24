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

            employee.COMM = Convert.ToDouble(addEmployeeViewModel.COMM);
            employee.DateOfJoin = addEmployeeViewModel.DateOfJoin;
            employee.EmployeeName = addEmployeeViewModel.EmployeeName;
            employee.JOB = addEmployeeViewModel.JOB;
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
    }
}