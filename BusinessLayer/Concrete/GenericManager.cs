using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;

namespace BusinessLayer.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class
    {
        IGenericDal<T> _genericDal;

        public GenericManager(IGenericDal<T> genericDal)
        {
            _genericDal = genericDal;
        }
        public void TInsert(T item)
        {
            _genericDal.Insert(item);
        }

        public void TDelete(T item)
        {
            _genericDal.Delete(item);
        }

        public void TUpdate(T item)
        {
            _genericDal.Update(item);
        }

        public List<T> TGetList()
        {
            return _genericDal.GetListAll();
        }

        public T TGetByID(int id)
        {
            return _genericDal.GetByID(id);
        }
    }
}
