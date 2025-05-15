using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_web.Models.DTOs.CartDetailDTO
{
    public class CartDetailDtoPut
    {
        public int IdCartDetail { get; set; }

        [Required]
        [Range(1, 1000000)]
        public int Amount { get; set; }

    }
}
