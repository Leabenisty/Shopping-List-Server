//using Microsoft.AspNetCore.Mvc;
//using ShoppingList.Core.Services;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace Shopping_List.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class productController : ControllerBase
//    {
//        private readonly ICategoryService _categoryService;

//        public productController()
//        {
            
//        }

//        public ICategoryService CategoryService => _categoryService;

//        // GET: api/<CategoriesController>
//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAllProducts()
//        {
//            var products = await _ProductService.GetAllProductsAsync();
//            if (products == null || products.Count == 0)
//            {
//                return Ok(new
//                {
//                    Status = "success",
//                    Message = "לא נמצאו פריטים",
//                    Data = new List<productDto>()
//                });
//            }
//            return Ok(new
//            {
//                Status = "success",
//                Message = "הפריטים נשלפו בהצלחה",
//                Data = products
//            });
//        }
//    }
//}
