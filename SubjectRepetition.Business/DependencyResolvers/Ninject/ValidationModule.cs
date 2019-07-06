using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Ninject.Modules;
using SubjectRepetition.Business.ValidationRules.FluentValidation;
using SubjectRepetition.Entities.Concrete;

namespace SubjectRepetition.Business.DependencyResolvers.Ninject
{
    public class ValidationModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Category>>().To<CategoryValidator>();
            Bind<IValidator<Product>>().To<ProductValidator>();
        }
    }
}
