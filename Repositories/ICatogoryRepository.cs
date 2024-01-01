using Shoppingapi.Dtos.Requests;
using Shoppingapi.Models;

namespace Shoppingapi.Repositories
{
    public interface ICatogoryRepository
    {
        Task<CatogoryProduct> StoreAsync(StoreCatogoryDto storeCatogoryDto);
        Task<CatogoryProduct?> GetAsync(int id);
        Task<List<CatogoryProduct>?> GetAllAsync();
        Task<bool> DeleteAsync(int id);
    }
}