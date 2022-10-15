using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context context = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = context.Set<T>();
        }
        public void Insert(T item)
        {
            _object.Add(item);
            context.SaveChanges();
        }

        public void Delete(T item)
        {
            _object.Remove(item);
            context.SaveChanges();
        }

        public void Update(T item)
        {
            //_object.Update(item);
            context.SaveChanges();
        }

        //public List<T> GetListAll()
        //{
        //    return _object.ToList();
        //}

        public T GetByID(int id)
        {
            return _object.Find(id);
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
            return filter == null ? _object.ToList() : context.Set<T>().Where(filter).ToList();
        }
    }
}
