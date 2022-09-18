using Microsoft.AspNetCore.Mvc;

namespace App
{
    [ApiController]
    [Route("[controller]")]
    public class DistanceController : ControllerBase
    {
        [HttpGet()]
        public List<Distance> Get([FromServices] IDistancesRepository repository)
        {
            return repository.All();
        }
    }
}
