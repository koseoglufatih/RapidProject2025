using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServicesDal _servicelDal;

        public ServiceManager(IServicesDal servicelDal)
        {
            _servicelDal = servicelDal;
        }

        public Service GetById(int id)
        {
            return _servicelDal.GetById(id);
        }

        public List<Service> TGetList()
        {
            return _servicelDal.GetList();
        }

        public void TDelete(Service t)
        {
            _servicelDal.Delete(t);
        }

        public void TInsert(Service t)
        {
            _servicelDal.Insert(t);
        }

        public void Update(Service t)
        {
            _servicelDal.Update(t);
        }
    }
}
