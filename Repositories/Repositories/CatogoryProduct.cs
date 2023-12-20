using AutoMapper;
using Shoppingapi.Models;

namespace Shoppingapi.Repositories.Repositories
{
    public class CatogoryProduct
    {

        private readonly ShoppingapiContext _context;
        private IMapper _mapper;

        public CatogoryProduct(ShoppingapiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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