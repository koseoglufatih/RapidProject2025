using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EF
{
    public class EfSendMessageDal : GenericRepository<SendMessage> , ISendMessageDal
    {
        public EfSendMessageDal(Context context) : base(context)
        {
            
        }

    }
}
