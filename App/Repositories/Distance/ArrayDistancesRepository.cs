namespace App
{
    class ArrayDistancesRepository : IDistancesRepository
    {
        private List<Distance> distances;

        public ArrayDistancesRepository()
        {
            distances = new List<Distance>();
            Add(new Distance(0, 100));
            Add(new Distance(100, 80));
            Add(new Distance(300, 70));
        }

        public List<Distance> All()
        {
            return distances;
        }

        public void Add(Distance distance)
        {
            distances.Add(distance);
        }
    }
}