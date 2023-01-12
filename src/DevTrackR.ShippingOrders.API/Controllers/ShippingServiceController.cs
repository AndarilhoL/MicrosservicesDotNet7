using DevTrackR.ShippingOrders.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace DevTrackR.ShippingOrders.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShippingServiceController : ControllerBase
    {
        private readonly IShippingServiceService _shippingService;

        public ShippingServiceController(IShippingServiceService shippingService)
        {
            _shippingService = shippingService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var shippingService = await _shippingService.GetAllAsync();
            
            return Ok(shippingService);
        }
    }
}