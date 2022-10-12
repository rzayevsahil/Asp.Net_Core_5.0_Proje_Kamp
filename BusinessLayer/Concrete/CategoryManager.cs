using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void TInsert(Category item)
        {
            _categoryDal.Insert(item);
        }

        public void TDelete(Category item)
        {
            _categoryDal.Delete(item);
        }

        public void TUpdate(Category item)
        {
            _categoryDal.Update(item);
        }

        public List<Category> TGetList()
        {
            return _categoryDal.GetListAll();
        }

        public Category TGetByID(int id)
        {
            return _categoryDal.GetByID(id);
        }
    }
}
