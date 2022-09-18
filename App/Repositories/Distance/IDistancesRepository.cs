namespace App
{
    public interface IDistancesRepository
    {
        public List<Distance> All();

        public void Add(Distance distance);
    }
}