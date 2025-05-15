using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using API_web.Models.DTOs.ProductDTO;

namespace API_web.Models.DTOs.CartDetailDTO
{
    public class CartDetailDtoGet
    {
        public int IdCartDetail { get; set; }
        public int Amount { get; set; }
        public decimal Subtotal { get; set; }
        public required ProductDtoSimple Products { get; set; }
        public int CartId { get; set; } 
    }
}
