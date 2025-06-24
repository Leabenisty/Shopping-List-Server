using ShoppingList.Core.Models;
using ShoppingList.Core.Repositories;
using ShoppingList.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Service.Services
{
    public class OrderListService : IOrderListService
    {

        private readonly IOrderListRepository repository;
        //private readonly IMapper mapper;

        public OrderListService(/*IMapper mapper,*/ IOrderListRepository repository)
        {
            //this.mapper = mapper; 
            this.repository = repository;
        }

        public async Task<List<OrderList>> GetAllOrderListAsync()
        {
            var categories = await repository.GetAllOrderListAsync();
            //var categoriesDto = mapper.Map<List<categoriesDto>>(categories);
            //return categoriesDto;
            return categories;
        }

    }
}
