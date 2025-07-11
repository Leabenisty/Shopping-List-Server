﻿using ShoppingList.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Core.Repositories
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetAllOrderAsync();
        Task<Order> AddOrder(Order order);

    }
}
