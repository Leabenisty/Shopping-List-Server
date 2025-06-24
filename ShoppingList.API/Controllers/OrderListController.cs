using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingList.Core.Models;
using ShoppingList.Core.Services;

namespace Shopping_List.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class OrderListController : Controller
    {
        
        private readonly IOrderListService _orderListService;

        public OrderListController(IOrderListService orderListService)
        {
            _orderListService = orderListService;

        }

        // GET: api/<OrderListController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderList>>> GetAllOrderList()
        {
            var OrderList = await _orderListService.GetAllOrderListAsync();
            if (OrderList == null || OrderList.Count == 0)
            {
                return Ok(new
                {
                    Status = "success",
                    Message = "לא נמצאו הזמנות",
                    Data = new List<OrderList>()
                });
            }
            return Ok(new
            {
                Status = "success",
                Message = "ההזמנות נשלפו בהצלחה",
                Data = OrderList
            });
        }



    }
}
