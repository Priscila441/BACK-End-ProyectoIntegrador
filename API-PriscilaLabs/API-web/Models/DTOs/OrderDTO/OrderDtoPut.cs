using API_web.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_web.Models.DTOs.OrderDTO
{
    public class OrderDtoPut
    {
        public int IdOrder { get; set; }

        [Column(TypeName = "decimal")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El total debe ser mayor que cero.")]
        public decimal TotalOrder { get; set; }

        public int AmountOrder { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public required StateOrder StateOrder { get; set; } = StateOrder.EnEspera;

        [Column(TypeName = "nvarchar(20)")]
        public required PaymentMethod PaymentMethod { get; set; } = PaymentMethod.MercadoPago;

    }
}
