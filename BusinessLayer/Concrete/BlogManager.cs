using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        EfBlogRepository efBlogRepository;

        public BlogManager()
        {
            efBlogRepository = new EfBlogRepository();
        }
        public void TInsert(Blog item)
        {
            efBlogRepository.Insert(item);
        }

        public void TDelete(Blog item)
        {
            efBlogRepository.Delete(item);
        }

        public void TUpdate(Blog item)
        {
            efBlogRepository.Update(item);
        }

        public List<Blog> TGetList()
        {
            return efBlogRepository.GetListAll();
        }

        public Blog TGetByID(int id)
        {
            return efBlogRepository.GetByID(id);
        }
    }
}
