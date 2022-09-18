using ccalc.Services;
using Microsoft.AspNetCore.Mvc;

namespace ccalc.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    [HttpGet]
    public double Get(ICalculatorService service, [FromQuery(Name = "distance")] int distance)
    {
        return service.CalculateDistancePrice(distance);
    }
}