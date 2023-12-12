using Shoppingapi.Mapper;
using Shoppingapi.Models;

namespace  Shoppingapi.Repositories.Repositories
{
    public class UserRepository
    {
        private readonly ShoppingapiContext _context;
        private readonly MapperProfile _mapper;
        public UserRepository(ShoppingapiContext context,MapperProfile mapper)
        {
            _context=context;
            _mapper=mapper;
        }
        public async Task<User> StoreAsync()
        {
            
        }
    }
}