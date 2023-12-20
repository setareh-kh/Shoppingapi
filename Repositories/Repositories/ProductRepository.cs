using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Shoppingapi.Dtos.Requests;
using Shoppingapi.Models;

namespace Shoppingapi.Repositories.Repositories
{
    public class ProductRepository:IProductRepository
    {
        private readonly ShoppingapiContext _context;
        private IMapper _mapper;
        public ProductRepository(ShoppingapiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Product> StoreAsync(StoreProductDto storeProduct)
        {
            Product newProduct = _mapper.Map<Product>(storeProduct);
            newProduct.CreateAt = DateTime.Now;
            await _context.Products.AddAsync(newProduct);
            await _context.SaveChangesAsync();
            return newProduct;
        }
        public async Task<Product?> GetByIdAsync(int id)
        {
            Product? product = await _context.Products.FindAsync(id);
            return product;
        }
        public async Task<List<Product>?> GetAllAsync()
        {
            List<Product>? products = await _context.Products.ToListAsync();
            return products;
        }
        public async Task<Product?> UpdateAsync(int id, UpdateProductDto updateProductDto)
        {
            Product? product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _mapper.Map(updateProductDto, product);
                product.UpdateDate = DateTime.Now;
                await _context.SaveChangesAsync();
                return product;
            }
            else
                return null;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            Product? product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
                return true;
            }
            else
                return false;
        }
    }
}