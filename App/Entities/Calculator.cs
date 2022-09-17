namespace App
{
    public class Calculator
    {
        private const int DEFAULT_PRICE = 100;

        public double calcPrice(List<Distance> distances, int distance)
        {
            if (!distances.Any())
                return DEFAULT_PRICE * distance;

            distances.Sort((Distance a, Distance b) => a.Start - b.Start);

            if (!distances.First().Start.Equals(0))
                distances.Insert(0, new Distance(0, DEFAULT_PRICE));

            double result = 0;
            int remainingDistance = distance;
            for (int i = 0; i < distances.Count; i++)
            {
                if (remainingDistance <= 0) break;

                Distance current = distances[i];
                Distance? next = distances.Count - i == 1 ? null : distances[i + 1];

                if (next != null)
                {
                    int slice = next.Start - current.Start;
                    remainingDistance -= slice;

                    if (remainingDistance >= 0)
                        result += slice * current.Price;
                    else
                        result += (slice - remainingDistance) * current.Price;
                }
                else
                {
                    result += remainingDistance * current.Price;
                    remainingDistance = 0;
                }
            }

            return result;
        }
    }
}