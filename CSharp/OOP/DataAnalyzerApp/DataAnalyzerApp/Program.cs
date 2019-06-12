using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Authentication;

namespace DataAnalyzerApp
{
    class Program
    {

        static void Main(string[] args)
        {
             SetLocalDiskPath();
          //  SetWebPath();

        }
        public static void SetLocalDiskPath()
        {
            const string path = @"E:\\SwabhavTech\dataFile.txt";
            Dictionary<Employee, Employee> employeDetailsList = new Dictionary<Employee, Employee>();

            CsvDataLoader csvDataLoader = new CsvDataLoader(path);
            employeDetailsList = csvDataLoader.Loader();
            CallEmployeAnalyzer(employeDetailsList);
        }

        public static void SetWebPath()
        {
            Dictionary<Employee, Employee> employeDetailsList = new Dictionary<Employee, Employee>();
            string url = "https://swabhav-tech.firebaseapp.com/emp.txt";

            WebDataLoader webDataLoader = new WebDataLoader(url);
            employeDetailsList = webDataLoader.Loader();
            CallEmployeAnalyzer(employeDetailsList);

        }
        public static void CallEmployeAnalyzer(Dictionary<Employee, Employee> employeDetailsList)
        {
            EmployeeAnalyzer employeeAnalayzer = new EmployeeAnalyzer(employeDetailsList);

            employeeAnalayzer.DepartmentWiseEmployeeCount();
            employeeAnalayzer.DesignationWiseEmployeeCount();
            employeeAnalayzer.MaxSalary();
            DisplayDetails(employeeAnalayzer);
        }
        public static void DisplayDetails(EmployeeAnalyzer employeeAnalyzerobj)
        {

            Employee employee1 = employeeAnalyzerobj.GetMaxSalaryEmployee;
            Dictionary<String, int> DepartmentWise = new Dictionary<string, int>();
            Dictionary<String, int> DesignationWise = new Dictionary<string, int>();
            DepartmentWise = employeeAnalyzerobj.GetDepartmentWiseEmployee;
            DesignationWise = employeeAnalyzerobj.GetDesignationWiseCount;

            Console.WriteLine("Maximum Salary EmployeeDetails :");

            Console.WriteLine("Employee Id             :" + employee1.EmployeeId);
            Console.WriteLine("Name                    :" + employee1.EmployeeName);
            Console.WriteLine("Designation             :" + employee1.EmployeeDesignation);
            Console.WriteLine("Manager ID              :" + employee1.ManagerId);
            Console.WriteLine("Date Of Join            :" + employee1.DateOfJoin);
            Console.WriteLine("Salary                  :" + employee1.Salary);
            Console.WriteLine("Comission               :" + employee1.Comission);
            Console.WriteLine("Department Number       :" + employee1.DepartmentNumber);

            foreach (KeyValuePair<string, int> count in DepartmentWise)
            {
                Console.WriteLine(count.Key + " " + count.Value);
            }

            foreach (KeyValuePair<string, int> count in DesignationWise)
            {
                Console.WriteLine(count.Key + " " + count.Value);
            }

        }
    }
}
