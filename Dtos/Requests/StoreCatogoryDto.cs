using System.ComponentModel.DataAnnotations;

namespace Shoppingapi.Dtos.Requests
{
    public class StoreCatogoryDto
    {
        [Required, MaxLength(250)]
        public required string Name { get; set; }
    }
}