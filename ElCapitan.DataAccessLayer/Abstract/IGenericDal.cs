using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElCapitan.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Add(T entity);
        void Delete(T id);
        void Edit(int id, T entity);
        T GetItemById(int id);
        List<T> GetAll();
    }
}
