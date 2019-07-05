using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubjectRepetition.Core.Entities;

namespace SubjectRepetition.Core.DataAccess.EntityFramework
{
    public class EfQueryableRepository<TEntity>:IQueryableRepository<TEntity> where TEntity:class,IEntity,new()
    {
        private DbContext _context;
        private IQueryable<TEntity> _entities;

        public IQueryable<TEntity> Table => _entities ?? (_entities = _context.Set<TEntity>());
       

        public EfQueryableRepository(DbContext context)
        {
            _context = context;
        }

        public IQueryable<TEntity> GetEntities()
        {
            return Table;
        }
    }
}
