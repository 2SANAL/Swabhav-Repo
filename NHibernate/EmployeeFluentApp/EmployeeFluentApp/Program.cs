using System;
using System.Linq;
using NHibernate;
using NHibernate.Linq;


namespace EmployeeFluentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // CreateTable();
            // GetData();
            // Update();
            // Delete();
        }

        private static void Update()
        {
            using (ISession session = EmployeeHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var employee = session.Query<Employee>().Single(m => m.Id == 1);
                    employee.FirstName = "Dhruv";
                    session.Update(employee);
                    transaction.Commit();
                }
            }
        }

        private static void Delete()
        {
            using (ISession session = EmployeeHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var employee = session.Query<Employee>().Single(m => m.FirstName.Equals("Dhruv"));
                    session.Delete(employee);
                    transaction.Commit();
                }
            }
        }


        private static void GetData()
        {
            using (ISession session = EmployeeHelper.OpenSession())
            {
                var employees = session.CreateCriteria<Employee>().List<Employee>();
                foreach (var employee in employees)
                {
                    Console.WriteLine(employee.Id + " " + employee.FirstName + " " + employee.LastName);
                }

            }
        }

        private static void CreateTable()
        {
            using (var session = EmployeeHelper.OpenSession())
            {
                var employee = new Employee { FirstName = "Sanal", LastName = "Jaiswal" };
                session.SaveOrUpdate(employee);
            }
        }
    }
}