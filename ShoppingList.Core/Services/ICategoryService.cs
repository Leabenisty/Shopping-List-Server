﻿using ShoppingList.Core.DTOs;
using ShoppingList.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Core.Services
{
    public interface ICategoryService
    {
       Task<List<CategoryDto>> GetAllCategoryAsync();

    }
}
