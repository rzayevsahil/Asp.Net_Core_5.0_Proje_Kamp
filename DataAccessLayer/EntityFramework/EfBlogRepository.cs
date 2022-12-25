using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using (var context = new Context())
            {
                return context.Blogs.Include(b => b.Category).ToList();
            }
        }

        public List<Blog> GetLastThreeBlogListByWriter(int id)
        {
            using (var context = new Context())
            {
                return context.Blogs.OrderByDescending(x => x.BlogCreateDate).Skip(context.Blogs.Count() - 3).ToList();
            }
        }
    }
}
