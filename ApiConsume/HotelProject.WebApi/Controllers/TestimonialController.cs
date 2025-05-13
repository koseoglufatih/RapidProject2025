using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonailService _testimonailService;

        public TestimonialController(ITestimonailService testimonailService)
        {
            _testimonailService = testimonailService;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = _testimonailService.TGetList();
            return Ok(values);

        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            _testimonailService.TInsert(testimonial);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonialf(int id)
        {
            var values = _testimonailService.GetById(id);
            _testimonailService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _testimonailService.Update(testimonial);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var values = _testimonailService.GetById(id);
            return Ok(values);
        }
    }
}
