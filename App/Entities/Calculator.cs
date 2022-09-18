namespace ccalc.Entities;

public static class Calculator
{
    private const int DefaultPrice = 100;

    public static double CalcPrice(List<Distance> distances, int distance)
    {
        if (distance <= 0)
            return 0;

        if (!distances.Any())
            return DefaultPrice * distance;

        distances.Sort((Distance a, Distance b) => a.Start - b.Start);

        if (!distances.First().Start.Equals(0))
            distances.Insert(0, new Distance(0, DefaultPrice));

        double result = 0;
        var remainingDistance = distance;
        for (var i = 0; i < distances.Count; i++)
        {
            if (remainingDistance <= 0) break;

            var current = distances[i];
            var next = i == distances.Count - 1 ? null : distances[i + 1];

            if (next != null)
            {
                var slice = next.Start - current.Start;
                remainingDistance -= slice;

                if (remainingDistance < 0)
                    slice += remainingDistance;

                result += slice * current.Price;
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