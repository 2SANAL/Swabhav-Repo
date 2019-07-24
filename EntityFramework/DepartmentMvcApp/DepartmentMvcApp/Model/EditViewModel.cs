using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DepartmentMvcApp.Model
{
    public class EditViewModel
    {
        public string DepartmentName { get; set; }
        public string Location { get; set; }
        public  Guid Id { get; set; }
    }
}