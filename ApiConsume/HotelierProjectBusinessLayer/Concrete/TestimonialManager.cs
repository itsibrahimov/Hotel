using HotelierProjectBusinessLayer.Abstract;
using HotelierProjectDataAccesLayer.Abstract;
using HotelierProjectEntityLayer.Concrete;

namespace HotelierProjectBusinessLayer.Concrete;

public class TestimonialManager : ITestimonialService
{
    private readonly ITestimonialDal _testimonialDal;

    public TestimonialManager(ITestimonialDal testimonialDal)
    {
        _testimonialDal = testimonialDal;
    }

    public void TDelete(Testimonial t)
    {
        _testimonialDal.Delete(t);
    }

    public Testimonial TGetById(int id)
    {
        return _testimonialDal.GetById(id);
    }

    public List<Testimonial> TGetList()
    {
        return _testimonialDal.GetList();
    }

    public void TInsert(Testimonial t)
    {
        _testimonialDal.Insert(t);
    }

    public void TUpdate(Testimonial t)
    {
        _testimonialDal.Update(t);
    }
}
