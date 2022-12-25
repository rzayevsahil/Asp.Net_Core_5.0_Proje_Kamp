using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : GenericManager<Category>, ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal) : base(new EfCategoryRepository())
        {
            _categoryDal = categoryDal;
        }
        public List<Category> TGetBlogsCountByCategory()
        {
            return _categoryDal.GetBlogsCountByCategory();
        }
    }
}
