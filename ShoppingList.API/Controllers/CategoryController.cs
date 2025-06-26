using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShoppingList.Core.DTOs;
using ShoppingList.Core.Models;
using ShoppingList.Core.Services;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shopping_List.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
  
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
          
        }

        // GET: api/<CategoriesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDto>>> GetAllCategories()
        {
            var categories = await _categoryService.GetAllCategoryAsync();
            return Ok(categories);
        }
      

    }
}
