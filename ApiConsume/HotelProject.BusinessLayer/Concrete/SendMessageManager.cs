﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Concrete
{
    public class SendMessageManager : ISendMessageService
    {
        private readonly ISendMessageDal _sendMessageDal;

        public SendMessageManager(ISendMessageDal sendMessageDal)
        {
            _sendMessageDal = sendMessageDal;
        }

        public SendMessage GetById(int id)
        {
            return _sendMessageDal.GetById(id);
        }

        public void TDelete(SendMessage t)
        {
            _sendMessageDal.Delete(t);
        }

        public List<SendMessage> TGetList()
        {
            return _sendMessageDal.GetList();
        }

        public int TGetSendMessageCount()
        {
            return _sendMessageDal.GetSendMessageCount();
        }

        public void TInsert(SendMessage t)
        {
            _sendMessageDal.Insert(t);
        }

        public void Update(SendMessage t)
        {
            _sendMessageDal.Update(t);
        }
    }
}
