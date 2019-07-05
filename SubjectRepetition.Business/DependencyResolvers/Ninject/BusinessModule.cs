using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using SubjectRepetition.Business.Abstract;
using SubjectRepetition.Business.Concrete;
using SubjectRepetition.DataAccess.Abstract;
using SubjectRepetition.DataAccess.Concrete.EntityFramework;

namespace SubjectRepetition.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<ICategoryDal>().To<EfCategoryDal>();
            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();

            Bind<IProductDal>().To<EfProductDal>();
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
        }
    }
}
