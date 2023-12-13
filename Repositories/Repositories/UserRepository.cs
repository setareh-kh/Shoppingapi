using AutoMapper;
using Dtos.Requests;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Shoppingapi.Dtos.Requests;
using Shoppingapi.Models;

namespace Shoppingapi.Repositories.Repositories
{
    public class UserRepository: IUserRepository
    {
        private readonly ShoppingapiContext _context;
        private IMapper _mapper;
        public UserRepository(ShoppingapiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<User> StoreAsync(StoreUserDto storeUserDto)
        {
            var newUser = _mapper.Map<User>(storeUserDto);
            newUser.CreateAt = DateTime.Now;
            await _context.Users.AddAsync(newUser);
            await _context.SaveChangesAsync();
            return newUser;
        }
        public async Task<User?> GetAsync(int Id)
        {
            User? user = await _context.Users.FindAsync(Id);
            return user ?? null;
        }
        public async Task<List<User>?> GetAllAsync()
        {
            var users = await _context.Users.ToListAsync();
            return users.Count > 0 ? users : null;
        }
        public async Task<bool> UpdateAsync(int Id, UpdateUserDto updateUserDto)
        {
            User? user = await _context.Users.FindAsync(Id);
            if (user != null)
            {
                _mapper.Map(updateUserDto, user);
                await _context.SaveChangesAsync();
                return true;
            }
            else
                return false;

        }
        public async Task<bool> DeleteAsync(int Id)
        {
            User? user = await _context.Users.FindAsync(Id);
            if (user != null)
            {
                _context.Remove(user);
                await _context.SaveChangesAsync();
                return true;
            }
            else
                return false;
        }
        public async Task<User?> LoginAsync(LoginUserDto loginUserDto)
        {
            var result= await _context.Users.Where(u=> u.Mobile==loginUserDto.Mobile && u.Password==loginUserDto.Password).ToListAsync();
            return result.Count>0 ? result.FirstOrDefault():null;
        } 
    }
}
