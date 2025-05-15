using API_web.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_web.Models.DTOs.UserDTO
{
    public class UserDtoPut
    {
        public int IdUser { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Range(13, 100)]
        public int Age { get; set; }

        [StringLength(100)]
        public string Direction { get; set; } = string.Empty;
    }
}
