using System;
using System.Collections.Generic;

namespace DataAnalyzerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const string path = @"E:\\SwabhavTech\dataFile.txt";
           const string url = "https://swabhav-tech.firebaseapp.com/emp.txt";

          //EmployeeAnalyzer employeeAnalyzer1 = new EmployeeAnalyzer(new DataParser(new CsvDataLoader(path)));
            EmployeeAnalyzer employeeAnalyzer2 = new EmployeeAnalyzer(new DataParser(new WebDataLoader(url)));
            DisplayDetails(employeeAnalyzer2);

        }



        public static void DisplayDetails(EmployeeAnalyzer employeeAnalyzerobj)
        {
            Dictionary<String, int> DepartmentWise = new Dictionary<string, int>();
            Dictionary<String, int> DesignationWise = new Dictionary<string, int>();

            Employee employee1 = employeeAnalyzerobj.MaxSalaryEmployee;
            DepartmentWise = employeeAnalyzerobj.DepartmentWiseEmployee;
            DesignationWise = employeeAnalyzerobj.DesignationWiseCount;

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
