using HotelierProjectDataAccesLayer.Abstract;
using HotelierProjectDataAccesLayer.Concrete;
using HotelierProjectDataAccesLayer.Repositories;
using HotelierProjectEntityLayer.Concrete;

namespace HotelierProjectDataAccesLayer.EntityFreamework;

public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
{
    public EfTestimonialDal(Context context) : base(context)
    {
    }
}
