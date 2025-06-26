using AutoMapper;
using ShoppingList.Core.DTOs;
using ShoppingList.Core.Models;
using ShoppingList.Models;


namespace Shopping_List.Service
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<Order, ProductPostModel>().ReverseMap();
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<OrderDto, OrderProduct>().ReverseMap();   
            CreateMap<Order, OrderDto>()
          .ForMember(dest => dest.OrderProducts, opt => opt.MapFrom(src => src.Products));
            CreateMap<OrderDto, Order>()
                .ForMember(dest => dest.Products, opt => opt.MapFrom(src => src.OrderProducts));

            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<ProductPostModel, OrderProduct>()
                .ForMember(dest => dest.ID, opt => opt.Ignore()) 
                .ForMember(dest => dest.OrderID, opt => opt.Ignore());
         

        }


    }
}
