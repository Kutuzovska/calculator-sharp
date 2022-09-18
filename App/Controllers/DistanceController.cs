using Microsoft.AspNetCore.Mvc;

namespace App
{
    [ApiController]
    [Route("[controller]")]
    public class DistanceController : ControllerBase
    {
        [HttpGet()]
        public List<Distance> Get(IDistancesRepository repository)
        {
            return repository.All();
        }

        [HttpPost()]
        public void Get(IDistancesRepository repository, [FromBody] Distance distance)
        {
            repository.Add(distance);
        }
    }
}
