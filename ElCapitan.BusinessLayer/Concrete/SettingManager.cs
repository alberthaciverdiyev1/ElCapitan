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
    public class SettingManager : ISettingService
    {
        private ISettingDal _settingDal;

        public SettingManager(ISettingDal settingDal)
        {
            _settingDal = settingDal;
        }

        public void TAdd(Setting entity)
        {
            _settingDal.Add(entity);
        }

        public void TDelete(Setting id)
        {
            _settingDal.Delete(id);
        }

        public void TEdit(int id, Setting entity)
        {
            _settingDal.Edit(id, entity);
        }

        public List<Setting> TGetAll()
        {
            return _settingDal.GetAll();
        }

        public Setting TGetItemById(int id)
        {
            return _settingDal.GetItemById(id);
        }
    }
}
