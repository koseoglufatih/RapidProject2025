﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Concrete
{
    public class WorkLocationManager : IWorkLocationService
    {
        private readonly IWorkLocationDal _workLocationDal;

        public WorkLocationManager(IWorkLocationDal workLocationDal)
        {
            _workLocationDal = workLocationDal;
        }

        public WorkLocation GetById(int id)
        {
            return _workLocationDal.GetById(id);
        }

        public void TDelete(WorkLocation t)
        {
            _workLocationDal.Delete(t);
        }

        public List<WorkLocation> TGetList()
        {
            return _workLocationDal.GetList();
        }

        public void TInsert(WorkLocation t)
        {
            _workLocationDal.Insert(t);
        }

        public void Update(WorkLocation t)
        {
            _workLocationDal.Update(t);
        }
    }
}
