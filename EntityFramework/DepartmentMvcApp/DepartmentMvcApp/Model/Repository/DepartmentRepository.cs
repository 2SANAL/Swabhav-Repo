using System;
using System.Collections.Generic;
using System.Linq;
using DepartmentMvcApp.BusinessModel;
using DepartmentMvcApp.Model;

namespace DepartmentMvcApp.Repository
{
    public class DepartmentRepository
    {
        private readonly AurionProContext _dbContext;

        public DepartmentRepository()
        {
            _dbContext = new AurionProContext();
        }

        public void AddDept(Department department)
        {
            _dbContext.Departments.Add(department);
            _dbContext.SaveChanges();
        }

        public IQueryable<Department> GetDepartments()
        {
            var departments = _dbContext.Departments;
            return departments;
        }

        public void AddUser(Login login)
        {
            _dbContext.Logins.Add(login);
            _dbContext.SaveChanges();
        }
        public void AddEmployee(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
        }

        public IQueryable<Employee> GetEmployees()
        {
            var employees = _dbContext.Employees;
            return employees;
        }

        public List<Employee> GetOnlye10Emp()
        {
            var total = _dbContext.Employees.Select(p => p.Id).Count();
            var pageSize = 5;
            var page = 1;
            var skip = pageSize * (page - 1);
            var canPage = skip < total;
            var a = _dbContext.Employees
                .OrderBy(m=>m.EmployeeName)
                .Skip(skip)
                .Take(pageSize).ToList();
            
            return a;
        }

        public IQueryable<Employee> GetEmployeesByDeptId(Guid id)
        {
            var employees = _dbContext.Employees.Where((m) => m.Department.Id == id);
            return employees;
        }

        public Department GetDepartmentById(Guid id)
        {
            var dept = _dbContext.Departments.Find(id);
            return dept;
        }
        public Employee GetEmployeeById(Guid id)
        {
            var employee = _dbContext.Employees.Find(id);
            return employee;
        }

        public void UpdateDept(EditViewModel editViewModel)
        {
            var u = _dbContext.Departments.Single(s => s.Id == editViewModel.Id);
            u.DepartmentName = editViewModel.DepartmentName;
            u.Location = editViewModel.Location;
            _dbContext.SaveChanges();
        }

        public void UpdateEmp(EditEmployeeViewModel editEmployeeViewModel)
        {
            var u = _dbContext.Employees.Single(s => s.Id == editEmployeeViewModel.Id);
            u.Comm = Convert.ToDouble(editEmployeeViewModel.Comm);
            u.DateOfJoin = editEmployeeViewModel.DateOfJoin;
            u.EmployeeName = editEmployeeViewModel.EmployeeName;
            u.Job = editEmployeeViewModel.Job;
            u.Salary = Convert.ToDouble(editEmployeeViewModel.Salary);
            _dbContext.SaveChanges();
        }
        public bool IsValidUser(LoginViewModel loginViewModel)
        {
            int isvalid = _dbContext.Logins.Where(m =>
                m.Username.Equals(loginViewModel.Password) && m.Password.Equals(loginViewModel.Password)).Count();
            if (isvalid > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IQueryable<Employee> GetEmployeesByName(string name)
        {
            var emplyees = _dbContext.Employees.Where(m => m.EmployeeName.Equals(name));
            return emplyees;
        }
    }
}