using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ContactManager : GenericManager<Contact>, IContactService
    {
        public ContactManager() : base(new EfContactRepository())
        {
        }
    }
}
