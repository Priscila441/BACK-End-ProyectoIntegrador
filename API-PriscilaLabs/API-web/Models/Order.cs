using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using API_web.Models.Enums;

namespace API_web.Models
{
    public class Order
    {
        [Key]
        public int IdOrder { get; set; }

        [Column(TypeName = "decimal")]
        //[Range(1, 15)]
        [Range(0.01, double.MaxValue, ErrorMessage = "El total debe ser mayor que cero.")]
        // minimo 0, sin limite de valor maximo
        public decimal TotalOrder { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateOrder { get; set; }

        public int AmountOrder { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public required StateOrder StateOrder { get; set; } = StateOrder.EnEspera;

        [Column(TypeName = "nvarchar(20)")]
        public required PaymentMethod PaymentMethod { get; set; } = PaymentMethod.MercadoPago;

        [ForeignKey("User")]
        [Required]
        public int UserId { get; set; }
        public required User User { get; set; } 
    }

    
}
