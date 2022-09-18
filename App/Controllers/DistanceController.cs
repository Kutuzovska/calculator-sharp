using ccalc.Entities;
using ccalc.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ccalc.Controllers;

[ApiController]
[Route("[controller]")]
public class DistanceController : ControllerBase
{
    [HttpGet]
    public List<Distance> Get(IDistancesRepository repository)
    {
        return repository.All();
    }

    [HttpPost]
    public void Get(IDistancesRepository repository, [FromBody] Distance distance)
    {
        repository.Add(distance);
    }
}