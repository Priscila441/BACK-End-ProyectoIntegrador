using API_web.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_web.Models.DTOs.UserDTO
{
    public class UserDtoPost
    {
        [Required]
        [StringLength(30)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Range(13, 100)]
        public int Age { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(10)]
        public string Password { get; set; } = string.Empty;


        [StringLength(100)]
        public string Direction { get; set; } = string.Empty;
        public required Role Role { get; set; } = Role.User; //valor por defecto 

    }
}
