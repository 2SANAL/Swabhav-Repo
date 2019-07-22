using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyAssosiationApp
{
    [Table("PRODUCT")]
    public class Product : Entity
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
    }
}
