using AutoMapper;
using GeekBurger.Ingredients.Api.Models;
using GeekBurguer.Ingredients.Contracts;

namespace GeekBurguer.Ingredients.Api.AutoMapper
{
    public class ApplicationProfile: Profile
    {
        public ApplicationProfile()
    {
        CreateMap<Product, ProductResponse>();
        CreateMap<ProductToGet, Product>();
        CreateMap<ItemToGet, Item>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ItemId));
    }
}
}
