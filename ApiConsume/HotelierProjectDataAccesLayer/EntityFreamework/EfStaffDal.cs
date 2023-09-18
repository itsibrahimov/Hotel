using HotelierProjectDataAccesLayer.Abstract;
using HotelierProjectDataAccesLayer.Concrete;
using HotelierProjectDataAccesLayer.Repositories;
using HotelierProjectEntityLayer.Concrete;

namespace HotelierProjectDataAccesLayer.EntityFreamework;

public class EfStaffDal : GenericRepository<Staff>, IStaffDal
{
    public EfStaffDal(Context context) : base(context)
    {
    }
}
