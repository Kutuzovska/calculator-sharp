using Microsoft.AspNetCore.Mvc;

namespace App
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpPost()]
        public double Get(ICalculatorService service)
        {
            return service.CalculateDistancePrice(305);
        }
    }
}
