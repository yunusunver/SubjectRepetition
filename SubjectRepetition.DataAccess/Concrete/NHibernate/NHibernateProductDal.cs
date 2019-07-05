using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubjectRepetition.Core.DataAccess.NHibernate;
using SubjectRepetition.DataAccess.Abstract;
using SubjectRepetition.DataAccess.Concrete.NHibernate.Helper;
using SubjectRepetition.Entities.Concrete;

namespace SubjectRepetition.DataAccess.Concrete.NHibernate
{
    public class NHibernateProductDal:NHibernateRepository<Product>,IProductDal
    {
        public NHibernateProductDal(SqlServerHelper sqlServerHelper) : base(sqlServerHelper)
        {
        }
    }
}
