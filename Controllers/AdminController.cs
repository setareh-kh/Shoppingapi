using Microsoft.AspNetCore.Mvc;
using Shoppingapi.Dtos.Requests;
using Shoppingapi.Repositories;

namespace Shoppingapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IProductRepository _productRepository;
        private readonly ICatogoryRepository _catogoryRepository;
        public AdminController(IUserRepository userRepository,IProductRepository productRepository,ICatogoryRepository catogoryRepository)
        {
            _userRepository = userRepository;
            _productRepository=productRepository;
            _catogoryRepository=catogoryRepository;

        }
        //ManagerUsers
        [HttpPost]
        [Route("ManagerUser/Register")]
        public async Task<IActionResult> StoreUserAsync(StoreUserDto storeUserDto)
        {
            var user = await _userRepository.StoreAsync(storeUserDto);
            return Ok(user);
        }
        [HttpGet]
        [Route("ManagerUser/ReadAll")]
        public async Task<IActionResult> GetAllUserAsync()
        {
            var users=await _userRepository.GetAllAsync();
            return Ok(users);
        }
        [HttpPut]
        [Route("ManagerUser/Update/{id}")]
        public async Task<IActionResult> UpdateUserAsync(int id,UpdateUserDto updateUserDto)
        {
            var user = await _userRepository.UpdateAsync(id,updateUserDto);
            return Ok(user);
        }
        [HttpDelete]
        [Route("ManagerUser/Delete/{id}")]
        public async Task<IActionResult> DeleteUserByIdAsync(int id)
        {
            bool isDeleted=await  _userRepository.DeleteAsync(id);
            return Ok(isDeleted==true ? "deleted is successfully":"No any user by this id");
        }
        //manageProduct
        [HttpPost]
        [Route("ManagerProduct/Register")]
        public async Task<IActionResult> StoreProductAsync(StoreProductDto storeProductDto)
        {
            var product = await _productRepository.StoreAsync(storeProductDto);
            return Ok(product);
        }
        [HttpGet]
        [Route("ManagerProduct/ReadAll")]
        public async Task<IActionResult> GetAllProdutAsync()
        {
            var products=await _productRepository.GetAllAsync();
            return Ok(products);
        }
        [HttpPut]
        [Route("ManagerProduct/Update/{id}")]
        public async Task<IActionResult> UpdateProductAsync(int id,UpdateProductDto updateProductDto)
        {
            var product = await _productRepository.UpdateAsync(id,updateProductDto);
            return Ok(product);
        }
        [HttpDelete]
        [Route("ManagerProduct/Delete/{id}")]
        public async Task<IActionResult> DeleteProductByIdAsync(int id)
        {
            bool isDeleted=await  _productRepository.DeleteAsync(id);
            return Ok(isDeleted==true ? "deleted is successfully":"No any product by this id");
        }
        //Manager Catogory
        [HttpPost]
        [Route("ManagerCatogoryProduct/Register")]
        public async Task<IActionResult> StoreCatogoryAsync(StoreCatogoryDto storeCatogoryDto)
        {
            var catogory = await _catogoryRepository.StoreAsync(storeCatogoryDto);
            return Ok(catogory);
        }
        [HttpGet]
        [Route("ManagerCatogoryProduct/ReadAll")]
        public async Task<IActionResult> GetAllCatogoryAsync()
        {
            var catogories=await _catogoryRepository.GetAllAsync();
            return Ok(catogories);
        }
        [HttpDelete]
        [Route("ManagerCatogoryProduct/Delete/{id}")]
        public async Task<IActionResult> DeleteCatogoryByIdAsync(int id)
        {
            bool isDeleted=await  _catogoryRepository.DeleteAsync(id);
            return Ok(isDeleted==true ? "deleted is successfully":"No any user by this id");
        }
        
    }
}