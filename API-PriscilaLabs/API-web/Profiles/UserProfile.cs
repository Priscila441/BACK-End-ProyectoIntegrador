
using API_web.Models;
using AutoMapper;
using API_web.Models.DTOs.UserDTO;
using API_web.Models.DTOs.OrderDTO;

namespace API_web.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDtoGet>();
            CreateMap<Order, OrderDtoSimple>();

            CreateMap<UserDtoPost, User>();
            CreateMap<UserDtoPut, User>();
        }
    }
}
