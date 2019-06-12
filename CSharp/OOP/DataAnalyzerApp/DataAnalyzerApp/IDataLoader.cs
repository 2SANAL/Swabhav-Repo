using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAnalyzerApp
{
    interface IDataLoader
    {
        Dictionary<Employee, Employee> Loader();
    }
}
