using System.Diagnostics.CodeAnalysis;

namespace App
{
    public class Distance
    {
        public required int Start { get; init; }

        public required double Price { get; init; }

        public Distance() { }

        [SetsRequiredMembers]
        public Distance(int Start, double Price)
        {
            if (Start < 0)
                throw new DistanceInvalidCreateException("Start position cannot be less than 0");

            if (Price <= 0)
                throw new DistanceInvalidCreateException("Too little price");

            this.Start = Start;
            this.Price = Price;
        }
    }
}

