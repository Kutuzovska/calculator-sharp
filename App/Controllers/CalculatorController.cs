using Microsoft.AspNetCore.Mvc;

namespace App
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpGet()]
        public double Get([FromServices] ICalculatorService service, [FromQuery(Name = "distance")] int distance)
        {
            return service.CalculateDistancePrice(distance);
        }
    }
}
