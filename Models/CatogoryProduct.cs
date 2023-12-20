using System.ComponentModel.DataAnnotations;

namespace Shoppingapi.Models
{
    public class CatogoryProduct
    {
        public int Id {get ; set;}
        [Required, MaxLength(250)]
        public required string Name {get ; set;}
    }
}