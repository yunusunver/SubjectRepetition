using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubjectRepetition.Core.DataAccess;
using SubjectRepetition.Entities.Concrete;

namespace SubjectRepetition.DataAccess.Abstract
{
    public interface IProductDal:IRepositoryBase<Product>
    {
    }
}
