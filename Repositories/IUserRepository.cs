using Shoppingapi.Dtos.Requests;
using Shoppingapi.Models;

namespace Repositories
{
    public interface IUserRepository
    {
        Task<User> StoreAsync(StoreUserDto storeUserDto);
        Task<User?> GetAsync(int Id);
        Task<List<User>?> GetAllAsync();
        Task<bool> UpdateAsync(int Id, UpdateUserDto updateUserDto);
        Task<bool> DeleteAsync(int Id);
        Task<User?> LoginAsync(LoginUserDto loginUserDto);
    }
}