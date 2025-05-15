using API_web.Models;
using API_web.Models.DTOs.CartDetailDTO;
using API_web.Models.DTOs.CartDTO;
using AutoMapper;

namespace API_web.Profiles
{
    public class CartProfile : Profile
    {
        public CartProfile()
        {
            CreateMap<Cart, CartDtoGet>();
            CreateMap<CartDetail, CartDetailDtoSimple>().ForMember(dest => dest.NameProduct, opt => opt.MapFrom(src => src.Product.NameProduct))
                        .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Product.Price));

            CreateMap<CartDtoPut, Cart>();
        }
    }
}
