using ElCapitan.DataAccessLayer.Abstract;
using ElCapitan.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElCapitan.DataAccessLayer.Repository
{
    internal class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Add(T t)
        {
            using var context = new Context();
            context.Set<T>().Add(t);
            context.SaveChanges();
        }

        public void Delete(T t)
        {
            using var context = new Context();
            context.Set<T>().Remove(t);
            context.SaveChanges();
        }

        public void Edit(int id, T t)
        {
            using var context = new Context();
            context.Set<T>().Update(t);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var context = new Context();
            return context.Set<T>().ToList();
        }

        public T GetItemById(int id)
        {
            using var context = new Context();

            return context.Set<T>().Find(id);
        }
    }
}
