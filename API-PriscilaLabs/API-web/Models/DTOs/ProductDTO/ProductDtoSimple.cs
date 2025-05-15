namespace API_web.Models.DTOs.ProductDTO
{
    public class ProductDtoSimple
    {
        public int IdProduct { get; set; }
        public string NameProduct { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
