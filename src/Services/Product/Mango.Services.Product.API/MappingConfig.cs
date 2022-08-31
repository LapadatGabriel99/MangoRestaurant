using AutoMapper;
using Mango.Services.Product.API.Dto;

namespace Mango.Services.Product.API
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<ProductDto, Models.Product>().ReverseMap();
        }
    }
}
