using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Shoppingapi.Dtos.Requests;
using Shoppingapi.Models;

namespace Shoppingapi.Repositories.Repositories
{
    public class CatogoryProductRepository:ICatogoryRepository
    {

        private readonly ShoppingapiContext _context;
        private IMapper _mapper;

        public CatogoryProductRepository(ShoppingapiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<CatogoryProduct> StoreAsync(StoreCatogoryDto storeCatogoryDto)
        {
            CatogoryProduct newCatogory = _mapper.Map<CatogoryProduct>(storeCatogoryDto);
            await _context.CatogoryProducts.AddAsync(newCatogory);
            await _context.SaveChangesAsync();
            return newCatogory;
        }
        public async Task<CatogoryProduct?> GetAsync(int id)
        {
            CatogoryProduct? catogory = await _context.CatogoryProducts.FindAsync(id);
            return catogory;

        }
        public async Task<List<CatogoryProduct>?> GetAllAsync()
        {
            List<CatogoryProduct> catogoryProducts = await _context.CatogoryProducts.ToListAsync();
            return catogoryProducts;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            CatogoryProduct? catogory = await _context.CatogoryProducts.FindAsync(id);
            if (catogory != null)
            {
                _context.CatogoryProducts.Remove(catogory);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;


        }
    }
}