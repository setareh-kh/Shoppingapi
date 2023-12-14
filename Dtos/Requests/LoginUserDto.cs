using System.ComponentModel.DataAnnotations;

namespace Shoppingapi.Dtos.Requests
{
    public class LoginUserDto
    {
        [Required, MaxLength(250)]
        public required string Mobile {get ; set;}
        [Required, MaxLength(250),MinLength(8)]
        public required string Password {get ; set;}
    }
}