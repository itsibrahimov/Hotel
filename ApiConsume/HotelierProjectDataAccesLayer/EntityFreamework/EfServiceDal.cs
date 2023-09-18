using HotelierProjectDataAccesLayer.Abstract;
using HotelierProjectDataAccesLayer.Concrete;
using HotelierProjectDataAccesLayer.Repositories;
using HotelierProjectEntityLayer.Concrete;

namespace HotelierProjectDataAccesLayer.EntityFreamework;

public class EfServiceDal : GenericRepository<Service>, IServiceDal
{
    public EfServiceDal(Context context) : base(context)
    {
    }
}
