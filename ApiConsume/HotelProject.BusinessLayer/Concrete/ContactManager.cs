﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public Contact GetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public void TDelete(Contact t)
        {
            _contactDal.Delete(t);
        }

        public int TGetContactCount()
        {
            return _contactDal.GetContactCount();
        }

        public List<Contact> TGetList()
        {
            return _contactDal.GetList();
        }

        public void TInsert(Contact t)
        {
            _contactDal.Insert(t);
        }

        public void Update(Contact t)
        {
            _contactDal.Update(t);
        }
    }
}
