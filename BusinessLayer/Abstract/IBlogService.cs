using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        List<Blog> TGetListWithCategory();
        List<Blog> GetBlogByID(int id);
        List<Blog> GetBlogListByWriter();
    }
}
