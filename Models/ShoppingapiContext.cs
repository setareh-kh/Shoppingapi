using Microsoft.EntityFrameworkCore;

namespace Shoppingapi.Models
{
    public class ShoppingapiContext:DbContext
    {
        public ShoppingapiContext(DbContextOptions<ShoppingapiContext> options): base(options)
        {
            
        }
        public DbSet<User> Users {get; set;}
        public DbSet<Product> Products {get; set;}
        public DbSet<CatogoryProduct>   {get; set;}
    }
}