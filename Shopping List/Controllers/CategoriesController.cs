using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shopping_List.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

        // GET: api/<CategoriesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        //public async Task<ActionResult<IEnumerable<ItemDto>>> GetAllItems()
        //{
        //    var items = await _itemService.GetAllItemsAsync();
        //    if (items == null || items.Count == 0)
        //    {
        //        return Ok(new
        //        {
        //            Status = "success",
        //            Message = "לא נמצאו פריטים",
        //            Data = new List<ItemDto>()
        //        });
        //    }
        //    return Ok(new
        //    {
        //        Status = "success",
        //        Message = "הפריטים נשלפו בהצלחה",
        //        Data = items
        //    });
        //}

    }
}
