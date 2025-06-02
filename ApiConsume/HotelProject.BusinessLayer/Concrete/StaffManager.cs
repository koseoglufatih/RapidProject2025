using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Concrete
{
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public Staff GetById(int id)
        {
            return _staffDal.GetById(id);
        }

        public List<Staff> TGetList()
        {
            return _staffDal.GetList();
        }

        public void TDelete(Staff t)
        {
            _staffDal.Delete(t);
        }

        public void TInsert(Staff t)
        {
            _staffDal.Insert(t);
        }

        public void Update(Staff t)
        {
            _staffDal.Update(t);
        }

        public int TGetStaffCount()
        {
            return (_staffDal.GetStaffCount()); 
        }

        public List<Staff> TLast4Satff()
        {
            return _staffDal.Last4Staff();
        }
    }
}
