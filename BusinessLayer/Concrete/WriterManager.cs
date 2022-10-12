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
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void TInsert(Writer item)
        {
            _writerDal.Insert(item);
        }

        public void TDelete(Writer item)
        {
            _writerDal.Delete(item);
        }

        public void TUpdate(Writer item)
        {
            _writerDal.Update(item);
        }

        public List<Writer> TGetList()
        {
            return _writerDal.GetListAll();
        }

        public Writer TGetByID(int id)
        {
            return _writerDal.GetByID(id);
        }
    }
}
