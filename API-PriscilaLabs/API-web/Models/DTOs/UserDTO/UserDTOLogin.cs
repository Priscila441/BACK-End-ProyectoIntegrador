using System.ComponentModel.DataAnnotations;

namespace API_web.Models.DTOs.UserDTO
{
    public class UserDTOLogin
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        [MinLength(10)]
        public string Password { get; set; } = string.Empty;

    }
}
