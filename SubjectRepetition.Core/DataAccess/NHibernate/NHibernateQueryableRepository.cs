using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubjectRepetition.Core.Entities;

namespace SubjectRepetition.Core.DataAccess.NHibernate
{
    public class NHibernateQueryableRepository<TEntity>:IQueryableRepository<TEntity> where TEntity:class,IEntity,new()
    {
        private NHibernateHelper _nHibernateHelper;
        private IQueryable<TEntity> _entities;
        private IQueryable<TEntity> Table => _entities ?? _nHibernateHelper.OpenSession().Query<TEntity>();
        public NHibernateQueryableRepository(NHibernateHelper nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }



        public IQueryable<TEntity> GetEntities()
        {
            return Table;
        }
    }
}
