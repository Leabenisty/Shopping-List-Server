using Microsoft.AspNetCore.Mvc;
using ShoppingList.Core.DTOs;
using ShoppingList.Core.Models;
using ShoppingList.Core.Services;
using ShoppingList.Models;

namespace Shopping_List.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {

        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;

        }

        // GET: api/<OrderListController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDto>>> GetAllOrderList()
        {
            var OrderList = await _orderService.GetAllOrderAsync();
            if (OrderList == null || OrderList.Count == 0)
            {
                return NotFound();
            }
            return Ok(OrderList);
        }


        [HttpPost]
        public async Task<ActionResult> Addorder(List<ProductPostModel> productPosts)
        {
            var OrderList = await _orderService.AddOrder(productPosts);

            return Ok(OrderList);

        }

    }
}
