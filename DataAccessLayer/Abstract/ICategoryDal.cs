using System.Collections.Generic;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        List<Category> GetBlogsCountByCategory();
    }
}
