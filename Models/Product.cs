using System.ComponentModel.DataAnnotations;

namespace Shoppingapi.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required, MaxLength(250)]
        public required string Name { get; set; }
        [Required]
        public required int Price { get; set; }
        [Required]
        public required int Quantity { get; set; }
        [Required]
        public required int Discount { get; set; }
        [Required]
        public required bool Available { get; set; }
        [Required]
        public required bool Active { get; set; }
        [Required]
        public required DateTime CreateAt { get; set; }
        //Fk 
        [Required]
        public required int CatogoryProductId { get; set; }
        public CatogoryProduct? CatogoryProduct { get; set; }

    }
}