using ccalc.Entities;

namespace ccalc.Repositories;

public interface IDistancesRepository
{
    public List<Distance> All();

    public void Add(Distance distance);
}