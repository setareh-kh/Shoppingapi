using System.ComponentModel.DataAnnotations;
using Shoppingapi.Models;

namespace Shoppingapi.Dtos.Requests
{
    public class StoreProductAdminDto
    {
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
        //Fk 
        [Required]
        public required int CatogoryProductId { get; set; }
        public CatogoryProduct? CatogoryProduct { get; set; }
    }
}