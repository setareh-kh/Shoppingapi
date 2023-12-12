using System.ComponentModel.DataAnnotations;

namespace Shoppingapi.Dtos.Requests
{
    public class StoreUserDto
    {
        [Required, MaxLength(250)]
        public required string Name {get ; set;}
        [Required, MaxLength(250)]
        public required string Mobile {get ; set;}
        [Required, MaxLength(250),MinLength(8)]
        public required string Password {get ; set;}
        public required byte Type {get ; set;}// 0 is admin and 1 is user
        [Required]
        public required DateTime CreateAt {get ; set;}
    }
}