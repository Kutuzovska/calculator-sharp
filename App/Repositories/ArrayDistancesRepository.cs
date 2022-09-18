using ccalc.Entities;

namespace ccalc.Repositories;

internal class ArrayDistancesRepository : IDistancesRepository
{
    private readonly List<Distance> _distances;

    public ArrayDistancesRepository()
    {
        _distances = new List<Distance>();
        Add(new Distance(0, 100));
        Add(new Distance(100, 80));
        Add(new Distance(300, 70));
    }

    public List<Distance> All()
    {
        return _distances;
    }

    public void Add(Distance distance)
    {
        _distances.Add(distance);
    }
}