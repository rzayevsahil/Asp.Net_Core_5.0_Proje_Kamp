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
    public class ContactManager : IContactService
    {
        EfContactRepository efContactRepository;

        public ContactManager()
        {
            efContactRepository = new EfContactRepository();
        }
        public void TInsert(Contact item)
        {
            efContactRepository.Insert(item);
        }

        public void TDelete(Contact item)
        {
            efContactRepository.Delete(item);
        }

        public void TUpdate(Contact item)
        {
            efContactRepository.Update(item);
        }

        public List<Contact> TGetList()
        {
            return efContactRepository.GetListAll();
        }

        public Contact TGetByID(int id)
        {
            return efContactRepository.GetByID(id);
        }
    }
}
