using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyAssosiationApp
{
    [Table("CUSTOMER")]
    public class Customer : Entity
    {
        public string CustomerName { get; set; }
        public string Location { get; set; }

        public virtual List<Order> Orders { get; set; }

        public Customer()
        {
            Orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
    }
}
