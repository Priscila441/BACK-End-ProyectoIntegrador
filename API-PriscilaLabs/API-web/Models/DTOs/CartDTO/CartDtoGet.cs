using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using API_web.Models.DTOs.CartDetailDTO;

namespace API_web.Models.DTOs.CartDTO
{
    public class CartDtoGet
    {
        public int IdCart { get; set; }
        public decimal Total { get; set; }
        public List<CartDetailDtoSimple> CartDetails { get; set; } = new();
    }

}

