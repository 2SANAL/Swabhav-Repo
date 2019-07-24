using System.Collections.Generic;
using DepartmentMvcApp.BusinessModel;

namespace DepartmentMvcApp.Model
{
    public class IndexViewModel
    {
        public List<Department> Departments { get; set; }
        public int Count { get; set; }
    }
}
