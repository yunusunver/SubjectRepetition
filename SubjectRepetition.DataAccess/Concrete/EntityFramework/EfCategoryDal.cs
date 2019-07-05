using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubjectRepetition.Core.DataAccess.EntityFramework;
using SubjectRepetition.DataAccess.Abstract;
using SubjectRepetition.Entities.Concrete;

namespace SubjectRepetition.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfRepositoryBase<Category,SubjectContext>,ICategoryDal
    {
    }
}
