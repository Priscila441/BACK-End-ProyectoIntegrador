using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using API_web.Models.Enums;

namespace API_web.Models
{
    public class Product
    {
        [Key]
        public int IdProduct { get; set; }

        [Required]
        [StringLength(20)]
        public string NameProduct { get; set; } = string.Empty;

        [StringLength(20)]
        public string Title { get; set; } = string.Empty;

        [StringLength(50)]
        public string Description { get; set; } = string.Empty;

        [StringLength(10)]
        public string Brand { get; set; } = string.Empty;

        [Range(1, 100000)]
        public int Stock { get; set; }

        [Required]
        [Column(TypeName = "decimal(15,2)")]
        public decimal Price { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public StateProduct StateProduct { get; set; } = StateProduct.Disponible; //me sirve para generar filtros luego

        [Required]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public required Category Category { get; set; } 
        public required List<CartDetail> CartDetails { get; set; } = new List<CartDetail>(); 

};
    

}
