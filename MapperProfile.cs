using AutoMapper;
using Shoppingapi.Dtos.Requests;
using Shoppingapi.Models;

namespace Shoppingapi.Mapper
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            //mapping requests dtos to entity class
            CreateMap<StoreUserDto,User>();
            CreateMap<StoreProductDto,Product>();
            CreateMap<StoreCatogoryDto,CatogoryProduct>();
            CreateMap<UpdateUserDto,User>();
            CreateMap<UpdateProductDto,Product>();
            

        }
    }
}