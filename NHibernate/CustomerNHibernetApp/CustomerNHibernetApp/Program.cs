
using System;
using System.Linq;
using System.Reflection;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Linq;
using NHibernate.Tool.hbm2ddl;

namespace CustomerNHibernetApp
{
    public class Program
    {
        private static Configuration cfg;

        static void Main(string[] args)
        {
            cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(Assembly.GetExecutingAssembly());
            var sessionFactory = cfg.BuildSessionFactory();
            using (ISession session = sessionFactory.OpenSession())
            {
                var customers = session.Query<Customer>().ToList();
                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Id + " " + customer.FirstName + " " + customer.LastName);
                }
            }
        }

        private static void CreateTable()
        {
            cfg.AddAssembly(Assembly.GetExecutingAssembly());
            new SchemaExport(cfg).Execute(true, true, false);
            var sessionFactory = cfg.BuildSessionFactory();

            using (ISession session = sessionFactory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(new Customer
                    {
                        FirstName = "Akash",
                        LastName = "Jaiswal"
                    });

                    transaction.Commit();
                }
            }
        }
    }
}
