
using System.Collections.Generic;


namespace DataAnalyzerApp
{
    class DataParser
    {
        private Employee _employee;
        private Dictionary<Employee, Employee> employeeList = new Dictionary<Employee, Employee>();
        private CsvDataLoader _csvDataloader;
        private WebDataLoader _webDataLoader;
        private string[] _lines;

        public DataParser(CsvDataLoader csvdataloader)
        {
            _csvDataloader = csvdataloader;

            _lines = _csvDataloader.lines;
            ParseData();
        }
        public DataParser(WebDataLoader webdataloader)
        {
            _webDataLoader = webdataloader;

            _lines = _webDataLoader.lines;
            ParseData();
        }

        public void ParseData()
        {

            foreach (string line in _lines)
            {
                string[] dataList = line.Split(',');
                _employee = new Employee(dataList[0], dataList[1], dataList[2], dataList[3], dataList[4], dataList[5], dataList[6], dataList[7]);

                if (!employeeList.ContainsKey(_employee))
                {
                    employeeList.Add(_employee, _employee);
                }
            }

        }
        public Dictionary<Employee, Employee> EmployeeList
        {
            get
            {
                return employeeList;
            }
        }
    }
}
