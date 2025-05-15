using API_web.Models;
using API_web.Models.DTOs.CartDetailDTO;
using API_web.Models.DTOs.ProductDTO;
using AutoMapper;

namespace API_web.Profiles
{
    public class CartDetailProfile : Profile
    {
        public CartDetailProfile()
        {
            CreateMap<CartDetail, CartDetailDtoGet>().ForMember(dest => dest.Products, opt => opt.MapFrom(src => src.Product));
            CreateMap<Product, ProductDtoSimple>();

            CreateMap<CartDetailDtoPost, CartDetail>();
            CreateMap<CartDetailDtoPut, CartDetail>();
        }
    }
}
