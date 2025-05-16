using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_web.Models.DTOs.CartDetailDTO
{
    public class CartDetailDtoPost
    {
        [Required]
        [Range(1, 1000000)]
        public int Amount { get; set; }

        public int ProductId { get; set; }

        public int CartId { get; set; }
    }
}
