using ElCapitan.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElCapitan.DataAccessLayer.Abstract
{
    public interface ICategoryDal
    {
        void Add(Category category);
        void Update(Category category);


    }
}
