using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyAssosiationApp
{
    [Table("ORDER")]
    public class Order : Entity
    {
        public string Date { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual List<LineItem> LineItems { get; set; }

        public Order()
        {
            LineItems = new List<LineItem>();
        }

        public void AddItem(LineItem item)
        {
            LineItems.Add(item);
        }
    }
}
