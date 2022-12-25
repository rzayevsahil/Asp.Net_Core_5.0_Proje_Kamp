using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class WriterManager : GenericManager<Writer>, IWriterService
    {
        public WriterManager() : base(new EfWriterRepository())
        {
        }
    }
}
