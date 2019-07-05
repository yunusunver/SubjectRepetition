using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubjectRepetition.Business.Abstract;
using SubjectRepetition.DataAccess;
using SubjectRepetition.DataAccess.Abstract;
using SubjectRepetition.Entities.Concrete;

namespace SubjectRepetition.Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetListCategories()
        {
            return _categoryDal.GetList();
        }

        public Category Get(int id)
        {
            return _categoryDal.Get(x => x.CategoryID == id);
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }
    }
}
