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
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository efCategoryRepository;

        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();
        }
        public void TInsert(Category item)
        {
            efCategoryRepository.Insert(item);
        }

        public void TDelete(Category item)
        {
            efCategoryRepository.Delete(item);
        }

        public void TUpdate(Category item)
        {
            efCategoryRepository.Update(item);
        }

        public List<Category> TGetList()
        {
            return efCategoryRepository.GetListAll();
        }

        public Category TGetByID(int id)
        {
            return efCategoryRepository.GetByID(id);
        }
    }
}
