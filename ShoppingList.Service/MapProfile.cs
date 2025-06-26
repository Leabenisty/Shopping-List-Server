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
            //            CreateMap<Product, ProductPostModel>()
            ////.ForMember(dest => dest., opt => opt.MapFrom(src => src.User.Fname))
            //.ReverseMap();
            //CreateMap<Product, ProductDto>().ReverseMap();

            CreateMap<Order, ProductPostModel>().ReverseMap();
            CreateMap<Order, OrderDto>().ReverseMap();
            //CreateMap<ProductPostModel, OrderProduct>().ReverseMap();
            CreateMap<OrderDto, OrderProduct>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();




            CreateMap<ProductPostModel, OrderProduct>()
                .ForMember(dest => dest.ID, opt => opt.Ignore()) // ID will be auto-generated, likely by the DB
                .ForMember(dest => dest.OrderID, opt => opt.Ignore());// OrderID will be set elsewhere
                 //.ForMember(dest => dest.Order, opt => opt.Ignore()); // Navigation property

            CreateMap<Order, OrderDto>()
          .ForMember(dest => dest.OrderProducts, opt => opt.MapFrom(src => src.Products));

            CreateMap<OrderDto, Order>()
                .ForMember(dest => dest.Products, opt => opt.MapFrom(src => src.OrderProducts));


        }


    }
}
