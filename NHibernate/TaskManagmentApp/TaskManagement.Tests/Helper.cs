using TaskManagment.Core.BusinessModel;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace TaskManagement.Tests
{
 public  class Helper
    {
        public static ISession OpenSession()

        {
            string connectionString = @"Data Source=.\MSSQLSERVER1;Initial Catalog=TaskManagement;Integrated Security=True";

            ISessionFactory sessionFactory = Fluently.Configure()

                .Database(MsSqlConfiguration.MsSql2012

                    .ConnectionString(connectionString).ShowSql()

                )

                .Mappings(m =>

                    m.FluentMappings

                        .AddFromAssemblyOf<User>())

                .ExposeConfiguration(cfg => new SchemaUpdate(cfg)

                    .Execute(false, true))

                .BuildSessionFactory();

            return sessionFactory.OpenSession();
        }

    }
}