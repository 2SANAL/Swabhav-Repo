using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace OneToManyMarginApp
{
   public class Grade
    {
        [Key]
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }

        public ICollection<Student2> Students { get; set; }
    }
}
