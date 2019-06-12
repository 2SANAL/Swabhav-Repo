using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataAnalyzerApp
{
    class CsvDataLoader : IDataLoader
    {


        private readonly string _path;
        Dictionary<Employee, Employee> employeelistDataParser = new Dictionary<Employee, Employee>();
        
      

        public CsvDataLoader(string path)
        {
            _path = path;
        }

        public Dictionary<Employee, Employee> Loader()
        {
            DataParser _dataParser = new DataParser();
            string[] lines = File.ReadAllLines(_path);

            employeelistDataParser = _dataParser.ParseData(lines);
            return employeelistDataParser;
        }

    }
}
