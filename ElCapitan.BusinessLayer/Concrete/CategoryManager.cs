using ElCapitan.BusinessLayer.Abstract;
using ElCapitan.DataAccessLayer.Abstract;
using ElCapitan.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElCapitan.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TAdd(Category entity)
        {
            _categoryDal.Add(entity);
        }

        public void TDelete(Category id)
        {
            _categoryDal.Delete(id);
        }

        public void TEdit(int id, Category entity)
        {
            _categoryDal.Edit(id, entity);
        }

        public List<Category> TGetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category TGetItemById(int id)
        {
            return _categoryDal.GetItemById(id);
        }
    }
}
