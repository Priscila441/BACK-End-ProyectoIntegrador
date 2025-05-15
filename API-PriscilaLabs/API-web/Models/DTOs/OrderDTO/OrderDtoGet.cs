using API_web.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_web.Models.DTOs.OrderDTO
{
    public class OrderDtoGet
    {
        public int IdOrder { get; set; }
        public decimal TotalOrder { get; set; }
        public DateTime DateOrder { get; set; }
        public int AmountOrder { get; set; }
        public required StateOrder StateOrder { get; set; } = StateOrder.EnEspera;
        public required PaymentMethod PaymentMethod { get; set; } = PaymentMethod.MercadoPago;
        public int UserId { get; set; }
    }
}
