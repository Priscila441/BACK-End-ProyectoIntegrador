using System.ComponentModel.DataAnnotations;

namespace API_web.Models
{
    public class Category
    {
        [Key]
        public int IdCategory { get; set; }

        [Required]
        [MaxLength(30)]
        [MinLength(3)]
        public string NameCategory { get; set; } = string.Empty;
        public required List<Product> Products { get; set; } = new List<Product>();
    }

    
}
