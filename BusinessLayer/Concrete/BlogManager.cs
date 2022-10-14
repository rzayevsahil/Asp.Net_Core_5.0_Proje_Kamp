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
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public List<Blog> TGetListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public void TInsert(Blog item)
        {
            _blogDal.Insert(item);
        }

        public void TDelete(Blog item)
        {
            _blogDal.Delete(item);
        }

        public void TUpdate(Blog item)
        {
            _blogDal.Update(item);
        }

        public List<Blog> TGetList()
        {
            return _blogDal.GetListAll();
        }

        public Blog TGetByID(int id)
        {
            return _blogDal.GetByID(id);
        }
    }
}
