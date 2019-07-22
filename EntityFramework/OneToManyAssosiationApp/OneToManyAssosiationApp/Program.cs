using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyAssosiationApp
{
    class Program
    {
        private static SwabhavDBContext dbContext = new SwabhavDBContext();
        static Guid id;
        static void Main(string[] args)
        {
            InitaileOperation();
            //   Update();
            //GEtLineItem();
        }
        private static void Update()
        {
            var orders = dbContext.Orders.Single();
            Console.WriteLine(orders.Id + " " + " " + orders.Date);

            var update = dbContext.Orders.First(s => s.Id == orders.Id);
            update.Date = "26-07-2019";

            dbContext.SaveChanges();
        }

        private static void GEtLineItem()
        {

            //var id = Guid.Parse("C08107E3-0AE2-4831-9DF1-55EA73C2A270");
            //var order = dbContext.Orders.Find(id);

            //foreach (var i in order.LineItems)
            //{
            //    id = i.Id;
            //}

            //var update = order.LineItems.First((s) => s.Id == id);
            //update.ProductName = "NoteBook";
            //dbContext.SaveChanges();

        }
        private static void InitaileOperation()
        {
            Order order = new Order();
            order.Date = "22-07-2019";

            LineItem item = new LineItem();
            item.Order = order;
            item.Quantity = 5;

            Product product = new Product();
            product.Price = 25;
            product.ProductName = "Mango";

            item.Product = product;
            order.AddItem(item);

            Customer customer = new Customer();
            customer.CustomerName = "Sanal";
            customer.Location = "Mumbai";
            customer.AddOrder(order);

            dbContext.Customers.Add(customer);
            dbContext.SaveChanges();
        }
    }

}
