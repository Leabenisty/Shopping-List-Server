using AutoMapper;
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
    public class CategoryService: ICategoryService
    {
        private readonly ICategoryRepository repository;
        //private readonly IMapper mapper;

        public CategoryService(/*IMapper mapper,*/ ICategoryRepository repository)
        {
            //this.mapper = mapper; 
            this.repository = repository;
        }
  
        public async Task<List<Category>> GetAllCategoryAsync() 
        {  
            var categories = await repository.GetAllCategoryAsync();
            //var categoriesDto = mapper.Map<List<categoriesDto>>(categories);
            //return categoriesDto;
            return categories;
        }

     
    }
}
