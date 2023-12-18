using Shoppingapi.Models;

namespace Shoppingapi.Repositories.Repositories
{
    public class CatogoryProduct
    {

        private ShoppingapiContext _context;
        public CatogoryProduct(ShoppingapiContext context)
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