using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_web.Models
{
    public class Cart
    {
        [Key]
        public int IdCart { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Total { get; set; }
        public required List<CartDetail> CartDetails { get; set; }
    }

}
