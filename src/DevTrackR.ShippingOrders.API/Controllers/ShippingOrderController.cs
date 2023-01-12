using DevTrackR.ShippingOrders.Application.InputModels;
using DevTrackR.ShippingOrders.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace DevTrackR.ShippingOrders.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShippingOrderController : ControllerBase
    {
        private readonly IShippingOrderService _orderService;

        public ShippingOrderController(IShippingOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("{code}")]
        public async Task<IActionResult> GetByCode(string code)
        {
            var shippingOrder = await _orderService.GetByCode(code);

            if(shippingOrder == null)
                return NotFound();
            return Ok(shippingOrder);
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddShippingOrderInputModel model)
        {
            var code = await _orderService.Add(model);

            return CreatedAtAction(
                nameof(GetByCode),
                new {code},
                model
            );
        }
    }
}