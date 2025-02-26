using Microsoft.AspNetCore.Mvc;
using MiniSiparisYonetimi.Models;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    private readonly OrderBLL _orderBLL;

    public OrderController(OrderBLL orderBLL)
    {
        _orderBLL = orderBLL;
    }

    [HttpPost]
    public IActionResult NewOrder([FromBody] Order order)
    {
        try
        {
            _orderBLL.NewOrder(order);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    public IActionResult OrderList(){
        return Ok(_orderBLL.GetOrders());
    }
}