using API_web.Models;
using API_web.Models.DTOs.CategoryDTO;
using AutoMapper;

namespace API_web.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryDtoGet>();

            CreateMap<CategoryDtoPost, Category>();
            CreateMap<CategoryDtoPut, Category>();
        }
    }
}
