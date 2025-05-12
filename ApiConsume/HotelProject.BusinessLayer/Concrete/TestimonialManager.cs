using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonailService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public Testimonial GetById(int id)
        {
            return _testimonialDal.GetById(id);
        }

        public List<Testimonial> GetList()
        {
           return _testimonialDal.GetList();
        }

        public void TDelete(Testimonial t)
        {
           _testimonialDal.Delete(t);
        }

        public void TInsert(Testimonial t)
        {
            _testimonialDal.Insert(t);
        }

        public void Update(Testimonial t)
        {
            _testimonialDal.Update(t);
        }
    }
}
