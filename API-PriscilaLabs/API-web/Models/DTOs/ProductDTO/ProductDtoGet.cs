using API_web.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using API_web.Models.DTOs.CategoryDTO;

namespace API_web.Models.DTOs.ProductDTO
{
    public class ProductDtoGet
    {
        public int IdProduct { get; set; }
        public string NameProduct { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public StateProduct StateProduct { get; set; } = StateProduct.Disponible; //me sirve para generar filtros luego
        public required CategoryDtoSimple Category { get; set; }

    }
}
