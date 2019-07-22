using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DepartmentMvcApp.BusinessModel
{
    [Table("DEPARTMENT")]
    public class Department
    {
        [Key]
        public Guid Id { get; set; }
        public string DepartmentName { get; set; }
        public string Location { get; set; }
    }
}