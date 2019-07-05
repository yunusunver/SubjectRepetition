using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubjectRepetition.Business.Abstract;
using SubjectRepetition.DataAccess.Abstract;
using SubjectRepetition.Entities.Concrete;

namespace SubjectRepetition.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetList()
        {
            return _productDal.GetList();
        }

        public Product Get(int id)
        {
            return _productDal.Get(x => x.ProductID == id);
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }
    }
}
