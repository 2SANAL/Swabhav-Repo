using System;
using System.Linq;
using DepartmentMvcApp.BusinessModel;
using DepartmentMvcApp.Model;
using DepartmentMvcApp.Views.Department;
using DepartmentMvcApp.Views.Department;

namespace DepartmentMvcApp.Repository
{
    public class DepartmentRepository
    {
        private readonly AurionProContext dbContext = new AurionProContext();

        public void AddDept(Department department)
        {
            dbContext.Departments.Add(department);
            dbContext.SaveChanges();
        }

        public IQueryable<Department> GetDepartments()
        {
            var departments = dbContext.Departments;
            return departments;
        }

        public void AddUser(Login login)
        {
            dbContext.Logins.Add(login);
            dbContext.SaveChanges();
        }
        public void AddEmployee(Employee employee)
        {
            dbContext.Employees.Add(employee);
            dbContext.SaveChanges();
        }

        public IQueryable<Employee> GetEmployees()
        {
            var employees = dbContext.Employees;
            return employees;
        }


        public IQueryable<Employee> GetEmployeesByDeptId(Guid id)
        {
            var employees = dbContext.Employees.Where((m) => m.Department.Id == id);
            return employees;
        }

        public Department GetDepartmentById(Guid id)
        {
            var dept = dbContext.Departments.Find(id);
            return dept;
        }

        public void Update(EditViewModel editViewModel)
        {
            var u = dbContext.Departments.Single(s=>s.Id==editViewModel.Id);
            u.DepartmentName = editViewModel.DepartmentName;
            u.Location = editViewModel .Location;
            dbContext.SaveChanges();

        }

        public bool IsValidUser(LoginViewModel loginViewModel)
        {
            int isvalid = dbContext.Logins.Where(m =>
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
    }
}