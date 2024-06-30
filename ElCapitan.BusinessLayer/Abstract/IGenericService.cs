using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElCapitan.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TAdd(T entity);
        void TDelete(T id);
        void TEdit(int id, T entity);
        T TGetItemById(int id);
        List<T> TGetAll();
    }
}
