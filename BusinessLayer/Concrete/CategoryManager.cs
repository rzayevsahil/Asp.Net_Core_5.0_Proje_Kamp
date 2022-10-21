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
    public class CategoryManager : GenericManager<Category>, ICategoryService
    {
        ICategoryDal _categoryDal = new EfCategoryRepository();
        
        public CategoryManager(IGenericDal<Category> genericDal) : base(genericDal)
        {
        }

        public List<Category> TGetBlogsCountByCategory()
        {
            return _categoryDal.GetBlogsCountByCategory();
        }
    }
}
