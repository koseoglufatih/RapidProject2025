﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Concrete
{
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomdal;

        public RoomManager(IRoomDal roomdal)
        {
            _roomdal = roomdal;
        }

        public Room GetById(int id)
        {
            return _roomdal.GetById(id);
        }

        public List<Room> TGetList()
        {
            return _roomdal.GetList();
        }

        public void TDelete(Room t)
        {
            _roomdal.Delete(t);
        }

        public void TInsert(Room t)
        {
            _roomdal.Insert(t);
        }

        public void Update(Room t)
        {
            _roomdal.Update(t);
        }

        public int TRoomCount()
        {
            return _roomdal.RoomCount();
        }
    }
}
