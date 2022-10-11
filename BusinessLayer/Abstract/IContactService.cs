using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactService
    {
        void ContactInsert(Contact contact);
        void ContactDelete(Contact contact);
        void ContactUpdate(Contact contact);
        List<Contact> GetList();
        Contact GetByID(int id);
    }
}
