using Shoppingapi.Dtos.Requests;
using Shoppingapi.Models;

namespace Shoppingapi.Repositories
{
    public interface IProductRepository
    {
        Task<Product> StoreAsync(StoreProductDto storeProduct);
        Task<Product?> GetByIdAsync(int id);
        Task<List<Product>?> GetAllAsync();
        Task<Product?> UpdateAsync(int id, UpdateProductDto updateProductDto);
        Task<bool> DeleteAsync(int id);

    }
}