﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Concrete
{
    public class GuestManager : IGuestService
    {
        private readonly IGuestDal _guestDal;

        public GuestManager(IGuestDal guestDal)
        {
            _guestDal = guestDal;
        }

        public Guest GetById(int id)
        {
            return _guestDal.GetById(id);
        }

        public void TDelete(Guest t)
        {
            _guestDal.Delete(t);
        }

        public List<Guest> TGetList()
        {
            return _guestDal.GetList();
        }

        public void TInsert(Guest t)
        {
            _guestDal.Insert(t);
        }

        public void Update(Guest t)
        {
            _guestDal.Update(t);
        }
    }
}
