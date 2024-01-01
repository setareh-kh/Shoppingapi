using Shoppingapi.Dtos.Requests;
using Shoppingapi.Models;

namespace Shoppingapi.Repositories
{
    public interface IProductRepository
    {
        Task<Product> StoreAsync(StoreProductDto storeProduct);
        Task<Product?> GetByIdAsync(int id);
        Task<List<Product>?> GetAllAsync();
        Task<List<Product>?> GetByNameAsync(string name);
        Task<List<Product>?> FilterOnPriceAsync(int maxPrice,int minPrice=0 );
        Task<Product?> UpdateAsync(int id, UpdateProductDto updateProductDto);
        Task<bool> DeleteAsync(int id);

    }
}