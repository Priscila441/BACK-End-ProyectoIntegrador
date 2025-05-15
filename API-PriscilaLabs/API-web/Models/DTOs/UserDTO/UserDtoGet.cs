using API_web.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using API_web.Models.DTOs.OrderDTO;

namespace API_web.Models.DTOs.UserDTO
{
    public class UserDtoGet
    {
        public int IdUser { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Direction { get; set; } = string.Empty;
        public required Role Role { get; set; } = Role.User; //valor por defecto 
        public List<OrderDtoSimple> Orders { get; set; } = new();

    }
}
