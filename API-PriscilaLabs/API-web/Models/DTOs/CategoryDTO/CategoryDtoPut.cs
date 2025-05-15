using System.ComponentModel.DataAnnotations;

namespace API_web.Models.DTOs.CategoryDTO
{
    public class CategoryDtoPut
    {
        public int IdCategory { get; set; }

        [Required]
        [MaxLength(30)]
        [MinLength(3)]
        public string NameCategory { get; set; } = string.Empty;
    }
}
