using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class BlogManager : GenericManager<Blog>, IBlogService
    {
        IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal) : base(new EfBlogRepository())
        {
            _blogDal = blogDal;
        }

        public List<Blog> TGetListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public List<Blog> TGetBlogByID(int id)
        {
            return _blogDal.GetListAll(x => x.BlogID == id);
        }

        public List<Blog> TGetBlogListByWriter(int id)
        {
            return _blogDal.GetListAll(x => x.WriterID == id);
        }

        public List<Blog> TGetLastThreeBlogListByWriter(int id)
        {
            return _blogDal.GetLastThreeBlogListByWriter(id);
        }
    }
}
