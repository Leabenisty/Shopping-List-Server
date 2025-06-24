using AutoMapper;
using ShoppingList.Core.Models;
using ShoppingList.Models;


namespace Shopping_List.Service
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductPostModel>().ReverseMap();
            //CreateMap<OrderList, OrderPostModel>().ReverseMap();
            //CreateMap<Category, CategoryPostModel>().ReverseMap();
        }
    }
}