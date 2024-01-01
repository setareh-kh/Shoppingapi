using Microsoft.AspNetCore.Mvc;
using Shoppingapi.Dtos.Requests;
using Shoppingapi.Repositories;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IProductRepository _productRepository;
        public UserController(IUserRepository userRepository,IProductRepository productRepository)
        {
            _userRepository = userRepository;
            _productRepository=productRepository;

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
        [Route("UpdateUser/{Id}")]
        public async Task<IActionResult> UpdateUserAsync(int Id,UpdateUserDto updateUserDto)
        {
            var result = await _userRepository.UpdateAsync(Id, updateUserDto);
            return Ok(result==true?"update is successfully":"update faild");
        }
        [HttpGet]
        [Route("ShowAllProduct")]
        public async Task<IActionResult> ShowAllProductsAsync()
        {
            var products=await _productRepository.GetAllAsync();
            return Ok(products?.Count>0 ? products : "No Any Products"); 
        }
        [HttpGet]
        [Route("GetByNameProduct")]
        public async Task<IActionResult> GetByNameProductAsync(string name)
        {
            var products=await _productRepository.GetByNameAsync(name);
            return Ok(products?.Count>0 ? products : "No Any Products"); 
        }
        [HttpGet]
        [Route("FilterOnPrice/{maxPrice}/{minPrice}")]
        public async Task<IActionResult> FilterOnPriceAsync(int maxPrice,int minPrice)
        {
            var products=await _productRepository.FilterOnPriceAsync(maxPrice,minPrice);
            return Ok(products?.Count>0 ? products : "No Any Products"); 
        }


    }
}