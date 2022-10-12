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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }
        public void TInsert(Contact item)
        {
            _contactDal.Insert(item);
        }

        public void TDelete(Contact item)
        {
            _contactDal.Delete(item);
        }

        public void TUpdate(Contact item)
        {
            _contactDal.Update(item);
        }

        public List<Contact> TGetList()
        {
            return _contactDal.GetListAll();
        }

        public Contact TGetByID(int id)
        {
            return _contactDal.GetByID(id);
        }
    }
}
