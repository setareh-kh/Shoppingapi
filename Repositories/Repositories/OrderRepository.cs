using Shoppingapi.Models;

namespace Shoppingapi.Repositories.Repositories
{
    public class OrderRepository
    {
        private ShoppingapiContext _context;
        public OrderRepository(ShoppingapiContext context)
        {
            _context = context;
        }
        public async Task<Product> StoreAsync()
        {

        }
        public async Task<Product?> GetAsync()
        {

        }
        public async Task<List<Product>?> GetAllAsync()
        {

        }
        public async Task<Product> UpdateAsync()
        {

        }
        public async Task<bool> DeleteAsync()
        {

        }
    }
}