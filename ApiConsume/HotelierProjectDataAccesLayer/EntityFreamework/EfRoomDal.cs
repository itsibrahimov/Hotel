using HotelierProjectDataAccesLayer.Abstract;
using HotelierProjectDataAccesLayer.Concrete;
using HotelierProjectDataAccesLayer.Repositories;
using HotelierProjectEntityLayer.Concrete;

namespace HotelierProjectDataAccesLayer.EntityFreamework;

public class EfRoomDal : GenericRepository<Room>, IRoomDal
{
    public EfRoomDal(Context context) : base(context)
    {
    }
}