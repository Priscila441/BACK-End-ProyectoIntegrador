
using API_web.Models;
using AutoMapper;
using API_web.Models.DTOs.ProductDTO;
using API_web.Models.DTOs.CategoryDTO;

namespace API_web.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDtoGet>();
            CreateMap<Category, CategoryDtoSimple>();

            CreateMap<ProductDtoPost, Product>();
            CreateMap<ProductDtoPut, Product>();
        }
    }
}
