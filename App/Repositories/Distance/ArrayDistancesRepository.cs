namespace App
{
    class ArrayDistancesRepository : IDistancesRepository
    {
        public List<Distance> All()
        {
            List<Distance> distances = new List<Distance>();
            distances.Add(new Distance(0, 100));
            distances.Add(new Distance(100, 80));
            distances.Add(new Distance(300, 70));

            return distances;
        }
    }
}