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
    public class AboutManager : IAboutService
    {
        private EfAboutRepository efAboutRepository;

        public AboutManager()
        {
            efAboutRepository = new EfAboutRepository();
        }
        public void TInsert(About item)
        {
            efAboutRepository.Insert(item);
        }

        public void TDelete(About item)
        {
            efAboutRepository.Delete(item);
        }

        public void TUpdate(About item)
        {
            efAboutRepository.Update(item);
        }

        public List<About> TGetList()
        {
            return efAboutRepository.GetListAll();
        }

        public About TGetByID(int id)
        {
            return efAboutRepository.GetByID(id);
        }
    }
}
