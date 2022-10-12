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
    public class WriterManager : IWriterService
    {
        EfWriterRepository efWriterRepository;

        public WriterManager()
        {
            efWriterRepository = new EfWriterRepository();
        }

        public void TInsert(Writer item)
        {
            efWriterRepository.Insert(item);
        }

        public void TDelete(Writer item)
        {
            efWriterRepository.Delete(item);
        }

        public void TUpdate(Writer item)
        {
            efWriterRepository.Update(item);
        }

        public List<Writer> TGetList()
        {
            return efWriterRepository.GetListAll();
        }

        public Writer TGetByID(int id)
        {
            return efWriterRepository.GetByID(id);
        }
    }
}
