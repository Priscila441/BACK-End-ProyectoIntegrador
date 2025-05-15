using System.ComponentModel.DataAnnotations;

namespace API_web.Models.DTOs.CategoryDTO
{
    public class CategoryDtoGet
    {
        public int IdCategory { get; set; }
        public string NameCategory { get; set; } = string.Empty;
    }
}
