using Microsoft.AspNetCore.Mvc;
using Repositories;
using Shoppingapi.Dtos.Requests;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository=userRepository;

        }
        [HttpPost]
        [Route("Store")]
        public async Task<IActionResult> StoreUserAsync(StoreUserDto storeUserDto)
        {
            var user=await _userRepository.StoreAsync(storeUserDto);
            return Ok(user);
        }
    }
}