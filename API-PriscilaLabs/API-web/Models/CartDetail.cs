using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_web.Models
{
    public class CartDetail
    {
        [Key]
        public int IdCartDetail { get; set; }

        [Required]
        [Range(1, 1000000)]
        public int Amount { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Subtotal { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public required Product Product { get; set; }

        [ForeignKey("Cart")]
        public int CartId { get; set; }
        public required Cart Cart { get; set; }
    }
}
