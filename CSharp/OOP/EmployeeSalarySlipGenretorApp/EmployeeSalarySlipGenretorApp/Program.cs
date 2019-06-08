using System;

namespace EmployeeSalarySlipGenretorApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Employee employe;

            employe = new Manager("AKASH", "2-5-2017", 20000, "Manager");
            Disaplay(employe);
            employe = new Developer("Dhruv", "2-5-2019", 52000, "Developer");
            Disaplay(employe);
            employe = new Accountant("dipesh", "3-5-2019", 12000, "Accountant");
            Disaplay(employe);


        }
        public static void Disaplay(Employee employee)
        {
            Console.WriteLine(" Employee Name :" + employee.Name);
            Console.WriteLine(" Date of Joining :" + employee.DateOfJoin);
            Console.WriteLine(" Employe Type  :" + employee.EmployeeType);
            Console.WriteLine(" Basic Salary :" + employee.Salary);
            Console.WriteLine(" Salary :\n" + employee.ToString());
            Console.WriteLine();
        }
    }
}
