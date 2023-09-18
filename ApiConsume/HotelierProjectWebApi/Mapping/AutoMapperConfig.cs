using AutoMapper;
using HotelierProjectDtoLayer.Dtos.RoomDto;
using HotelierProjectEntityLayer.Concrete;

namespace HotelierProjectWebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();

            CreateMap<UpdateRoomDto, Room>().ReverseMap();
        }
    }
}
