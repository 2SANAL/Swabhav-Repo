
using System.Collections.Generic;


namespace DataAnalyzerApp
{
    class DataParser
    {
        private Employee _employee;
        private Dictionary<Employee, Employee> employeeList = new Dictionary<Employee, Employee>();
       

        public Dictionary<Employee, Employee> ParseData(string[] lines)
        {
            foreach (string line in lines)
            {
                string[] dataList = line.Split(',');
                _employee = new Employee(dataList[0], dataList[1], dataList[2], dataList[3], dataList[4], dataList[5], dataList[6], dataList[7]);

                if (!employeeList.ContainsKey(_employee))
                {
                    employeeList.Add(_employee, _employee);
                }
            }

            return employeeList;
        }
         
             

        
    }
}
