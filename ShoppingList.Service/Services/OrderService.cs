using AutoMapper;
using ShoppingList.Core.DTOs;
using ShoppingList.Core.Models;
using ShoppingList.Core.Repositories;
using ShoppingList.Core.Services;
using ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Service.Services
{
    public class OrderService : IOrderService
    {

        private readonly IOrderRepository repository;
        private readonly IMapper mapper;

        public OrderService(IMapper mapper, IOrderRepository repository)
        {
            this.mapper = mapper;
            this.repository = repository;
        }

        public async Task<OrderDto> AddOrder(List<ProductPostModel> productPosts)
        {

            Order order = new()
            {
                CreatedAt = DateTime.Now,
                Products = mapper.Map<List<OrderProduct>>(productPosts)
            };

            order = await repository.AddOrder(order);
            return mapper.Map<OrderDto>(order);
        }

        public async Task<List<OrderDto>> GetAllOrderAsync()
        { 
            var order = await repository.GetAllOrderAsync();
            var orderDto = mapper.Map<List<OrderDto>>(order);
            return orderDto;
        }

    }
}
