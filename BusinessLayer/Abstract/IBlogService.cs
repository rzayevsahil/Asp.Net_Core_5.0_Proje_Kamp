using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        List<Blog> TGetListWithCategory();
        List<Blog> TGetBlogByID(int id);
        List<Blog> TGetBlogListByWriter(int id);
        List<Blog> TGetLastThreeBlogListByWriter(int id);
    }
}
