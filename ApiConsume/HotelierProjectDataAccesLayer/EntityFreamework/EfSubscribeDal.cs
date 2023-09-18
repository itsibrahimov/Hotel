using HotelierProjectDataAccesLayer.Abstract;
using HotelierProjectDataAccesLayer.Concrete;
using HotelierProjectDataAccesLayer.Repositories;
using HotelierProjectEntityLayer.Concrete;

namespace HotelierProjectDataAccesLayer.EntityFreamework;

public class EfSubscribeDal : GenericRepository<Subscribe>, ISubscribeDal
{
    public EfSubscribeDal(Context context) : base(context)
    {
    }
}
