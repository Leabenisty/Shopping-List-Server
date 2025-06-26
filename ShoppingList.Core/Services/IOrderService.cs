using ShoppingList.Core.DTOs;
using ShoppingList.Core.Models;
using ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Core.Services
{
    
    public interface IOrderService
    {
        Task<List<OrderDto>> GetAllOrderAsync();
        Task<OrderDto> AddOrder(List<ProductPostModel> productPosts);
    }
}
