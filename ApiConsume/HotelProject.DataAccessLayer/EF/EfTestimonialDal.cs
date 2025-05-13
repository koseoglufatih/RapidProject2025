using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EF
{
    public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal

    {
        public EfTestimonialDal(Context context) : base(context)
        {
        }
    }
}
