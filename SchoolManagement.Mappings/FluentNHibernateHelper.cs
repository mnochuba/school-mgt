using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using SchoolManagement.DB.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DB
{
    public class FluentNHibernateHelper
    {
        private ISessionFactory _sessionFactory;
        //SessionFactory initilises the connection
        //between the model layer and the database layer

        public ISessionFactory SessionFactory => _sessionFactory ??
            Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString
                (_connectionString))
            .Mappings(m=>m.FluentMappings.AddFromAssemblyOf<StudentMap>())
            .ExposeConfiguration(cfg=>new SchemaExport(cfg).Create(true,true))
            .BuildSessionFactory();

        public ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

        private string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MURPHY NNAMDI\source\repos\SchoolManagement\ScoolDB.mdf;Integrated Security=True;Connect Timeout=30";
        private string _connectionString2 = @"Data Source=(LocalDB)\MSSQLLocalDB;Database=ScoolDB;Integrated Security=True;Connect Timeout=30";
     }
}
