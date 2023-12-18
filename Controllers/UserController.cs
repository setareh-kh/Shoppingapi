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
            _userRepository = userRepository;

        }
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> StoreUserAsync(StoreUserDto storeUserDto)
        {
            var user = await _userRepository.StoreAsync(storeUserDto);
            return Ok(user);
        }
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> LoginAsync(LoginUserDto loginUserDto)
        {
            var result = await _userRepository.LoginAsync(loginUserDto);
            return Ok(result != null ? result : "Login is faild");
        }
        [HttpPost]
        [Route("Update/{Id}")]
        public async Task<IActionResult> UpdateUserAsync(int Id,UpdateUserDto updateUserDto)
        {
            var result = await _userRepository.UpdateAsync(Id, updateUserDto);
            return Ok(result==true?"update is successfully":"update faild");
        }

    }
}