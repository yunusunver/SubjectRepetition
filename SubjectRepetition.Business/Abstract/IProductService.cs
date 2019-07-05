using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SubjectRepetition.Entities.Concrete;

namespace SubjectRepetition.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetList();
        Product Get(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
