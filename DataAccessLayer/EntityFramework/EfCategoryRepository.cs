using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfCategoryRepository : GenericRepository<Category>, ICategoryDal
    {
        public List<Category> GetBlogsCountByCategory()
        {
            using (var context = new Context())
            {
                return context.Categories.Include(x => x.Blogs).ToList();
            }
        }
    }
}
