using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using KurumsalFramework.Core.DataAccess.NHibernate;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KurumsalFramework.Northwind.DataAccess.NHibernate.Helpers
{
    public class SqlServerHelper : NHibernateHelper
    {
        public override ISessionFactory InitializeFactory()
        {
            return Fluently.Configure()
                 .Database(MsSqlConfiguration.MsSql2012.ConnectionString(x => x.FromConnectionStringWithKey("DefaultConnection")))
                 .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                 .BuildSessionFactory();
        }
    }
}
