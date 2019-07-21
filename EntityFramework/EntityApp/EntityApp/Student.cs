using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityApp
{
    [Table("STUDENT")]
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Cgpi { get; set; }
        public string Location { get; set; }
        public string Age { get; set; }
    }
}
