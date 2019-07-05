using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubjectRepetition.Core.DataAccess
{
    public interface IQueryableRepository<T> where T : class, T, new()
    {
        IQueryable<T> GetEntities();
    }
}
