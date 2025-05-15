namespace API_web.Models.DTOs.CartDetailDTO
{
    public class CartDetailDtoSimple
    {
        public int IdCartDetail { get; set; }
        public int Amount { get; set; }       
        public decimal Subtotal { get; set; }
        public required string NameProduct { get; set; }
        public decimal Price { get; set; }
    }
}
