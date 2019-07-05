using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using SubjectRepetition.Core.DataAccess.NHibernate;

namespace SubjectRepetition.DataAccess.Concrete.NHibernate.Helper
{
    public class SqlServerHelper:NHibernateHelper
    {
        public override ISessionFactory InitializeFactory()
        {
            return Fluently.Configure().Database(MsSqlConfiguration.MsSql7.ConnectionString("NortwindDatabase"))
                .Mappings(x=>x.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly())).BuildSessionFactory();
        }
    }
}
