using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShoppingList.Core.DTOs;
using ShoppingList.Core.Models;
using ShoppingList.Core.Services;
using ShoppingList.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shopping_List.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class productController : ControllerBase
    //{
    //    private readonly IProductService _productService;

    //    public productController(IProductService productService)
    //    {
    //        _productService = productService;
    //    }

    //    // GET: api/<ProductController>
    //    [HttpGet]
    //    public async Task<ActionResult<IEnumerable<ProductDto>>> GetAllProducts()
    //    {
    //        var products = await _productService.GetAllProductAsync();
    //        if (products == null || products.Count == 0)
    //        {
    //            return Ok(new
    //            {
    //                Status = "success",
    //                Message = "לא נמצאו מוצרים",
    //                Data = new List<ProductDto>()
    //            });
    //        }
    //        return Ok(new
    //        {
    //            Status = "success",
    //            Message = "המוצרים נשלפו בהצלחה",
    //            Data = products
    //        });
    //    }

    //    // DELETE: api/Product/{id}
    //    [HttpDelete("{id}")]
    //    public async Task<ActionResult<ProductDto>?> DeleteProduct(int id)
    //    {
    //        var existingProduct = await _productService.GetProductById(id);
    //        if (existingProduct == null)
    //        {
    //            return NotFound(new
    //            {
    //                Status = "error",
    //                Message = "המוצר לא נמצא"
    //            });
    //        }
    //        await _productService.DeleteProductAsync(id);

    //        return Ok(new
    //        {
    //            Status = "success",
    //            Message = "המוצר נמחק בהצלחה",
    //            Data = existingProduct
    //        });
    //    }

    //    // POST: api/Product
    //    [HttpPost("product")]
    //    public async Task<ActionResult<ProductDto>> PostProduct([FromForm] List<ProductPostModel> productPostModel)
    //    {       
    //        var result = await _productService.AddProductAsync(productPostModel);
    //        if (result == null)
    //        {
    //            return BadRequest(new
    //            {
    //                Status = "error",
    //                Message = "נכשל ביצירת המוצר"
    //            });
    //        }
    //        return Ok(new
    //        {
    //            Status = "success",
    //            Message = "המוצר נוסף בהצלחה",
    //            Data = result
    //        });
    //    }

    //}
}
