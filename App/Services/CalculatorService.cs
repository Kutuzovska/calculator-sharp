using ccalc.Entities;
using ccalc.Repositories;

namespace ccalc.Services;

public class CalculatorService : ICalculatorService
{
    private readonly IDistancesRepository _repository;

    public CalculatorService(IDistancesRepository repository)
    {
        _repository = repository;
    }

    public double CalculateDistancePrice(int distance)
    {
        var distances = _repository.All();
        return Calculator.CalcPrice(distances, distance);
    }
}