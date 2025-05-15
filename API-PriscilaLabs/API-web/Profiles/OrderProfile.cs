
using API_web.Models;
using AutoMapper;
using API_web.Models.DTOs.OrderDTO;

namespace API_web.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderDtoGet>();

            CreateMap<OrderDtoPost, Order>();
            CreateMap<OrderDtoPut, Order>();

            CreateMap<OrderPatchStatus, Order>();
        }
    }
}
