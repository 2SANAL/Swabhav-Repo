
using System.Collections.Generic;
using System.Linq;
using NHibernate.Linq;


namespace DeptEmpMappingApp
{
    class Program
    {
        static void Main(string[] args)
        {
           // CreateTable();
            Delet();
        }

        private static void Delet()
        {
            using (var session=Helper.OpenSession())
            {
                using (var transaction=session.BeginTransaction())
                {
                    var dept = session.Query<Department>().Single(m => m.Id == 2);
                    session.Delete(dept);
                    transaction.Commit();
                }
            }
        }
        private static void CreateTable()
        {


            using (var session = Helper.OpenSession())
            {
                Department department = new Department();
                Employee employee = new Employee();
                department.Employees = new List<Employee>();

                department.DepartmentName = "IT";
                department.Location = "Mumabi";
                department.Employees.Add(employee);

                employee.EName = "Dhruv";
                employee.Salary = 250000;
                employee.Department = department;

                session.SaveOrUpdate(department);

            }
        }
    }
}
