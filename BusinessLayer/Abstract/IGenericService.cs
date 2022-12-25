using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TInsert(T item);
        void TDelete(T item);
        void TUpdate(T item);
        List<T> TGetList();
        T TGetByID(int id);
    }
}
