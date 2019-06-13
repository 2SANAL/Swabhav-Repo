using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataAnalyzerApp
{
    class CsvDataLoader : IDataLoader
    {


        private readonly string _path;
        Dictionary<Employee, Employee> _employeelistDataParser = new Dictionary<Employee, Employee>();

        private string[] _lines;

        public CsvDataLoader(string path)
        {
            _path = path;
            Loader();
        }

        public void Loader()
        {
            
             _lines = File.ReadAllLines(_path);
        }

        public string[] lines
        {
            get
            {
                return _lines;
            }
        }

    }
}
