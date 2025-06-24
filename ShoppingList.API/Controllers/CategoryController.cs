using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<ActionResult<IEnumerable<Category>>> GetAllCategories()
        {
            var categories = await _categoryService.GetAllCategoryAsync();
            if (categories == null || categories.Count == 0)
            {
                return Ok(new
                {
                    Status = "success",
                    Message = "לא נמצאו פריטים",
                    Data = new List<Category>()
                });
            }
            return Ok(new
            {
                Status = "success",
                Message = "הפריטים נשלפו בהצלחה",
                Data = categories
            });
        }
      

    }
}
