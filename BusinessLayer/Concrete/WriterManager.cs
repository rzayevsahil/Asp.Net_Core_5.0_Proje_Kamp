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
    public class WriterManager : GenericManager<Writer>,IWriterService
    {
        public WriterManager(IGenericDal<Writer> genericDal) : base(genericDal)
        {
        }
    }
}
