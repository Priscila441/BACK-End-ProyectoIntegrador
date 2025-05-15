namespace API_web.Models.DTOs.OrderDTO
{
    public class OrderDtoSimple
    {
        public int IdOrder { get; set; }
        public decimal TotalOrder { get; set; }
        public DateTime DateOrder { get; set; }
    }
}
