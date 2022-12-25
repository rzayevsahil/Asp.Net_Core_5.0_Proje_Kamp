using System.Collections.Generic;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal : IGenericDal<Blog>
    {
        List<Blog> GetListWithCategory();
        List<Blog> GetLastThreeBlogListByWriter(int id);
    }
}
