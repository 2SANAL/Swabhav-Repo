
using System;
using System.ComponentModel.DataAnnotations;

namespace DepartmentMvcApp.Model
{
    public class AddViewModel
    {
        [Required]
        public string DepartmentName { get; set; }
        [Required]
        public string Location { get; set; }
        public Guid Id { get; set; }
    }
}