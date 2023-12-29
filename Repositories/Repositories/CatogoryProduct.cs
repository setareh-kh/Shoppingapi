using AutoMapper;
using Shoppingapi.Dtos.Requests;
using Shoppingapi.Models;

namespace Shoppingapi.Repositories.Repositories
{
    public class CatogoryProduct
    {

        private readonly ShoppingapiContext _context;
        private IMapper _mapper;

        public CatogoryProduct(ShoppingapiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<CatogoryProduct> StoreAsync(StoreCatogoryDto storeCatogoryDto)
        {   
            CatogoryProduct newCatogory=_mapper.Map<CatogoryProduct>(storeCatogoryDto);
            await _context.AddAsync(newCatogory);
            return newCatogory;
        }
        public async Task<CatogoryProduct?> GetAsync(int id)
        {
            CatogoryProduct catogory=await _context.g
        }
        public async Task<List<CatogoryProduct>?> GetAllAsync()
        {

        }
        public async Task<bool> DeleteAsync()
        {

        }
    }
}