using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace EmployeeFluentApp
{
    static class EmployeeHelper
    {
        public static ISession OpenSession()

        {

            string connectionString = @"Data Source=.\MSSQLSERVER1;Initial Catalog=NHibernateDB;Integrated Security=True";

            ISessionFactory sessionFactory = Fluently.Configure()

                .Database(MsSqlConfiguration.MsSql2012

                    .ConnectionString(connectionString).ShowSql()

                )

                .Mappings(m =>

                    m.FluentMappings

                        .AddFromAssemblyOf<Employee>())

                .ExposeConfiguration(cfg => new SchemaUpdate(cfg)

                    .Execute(false, true))

                .BuildSessionFactory();

            return sessionFactory.OpenSession();
        }

    }
}
