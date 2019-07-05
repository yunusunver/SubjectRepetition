using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace SubjectRepetition.Core.DataAccess.NHibernate
{
    public abstract class NHibernateHelper
    {
        public abstract ISessionFactory InitializeFactory();
        public ISessionFactory SessionFactory => _SessionFactory ?? (_SessionFactory = InitializeFactory());
        public ISessionFactory _SessionFactory;

        public ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
