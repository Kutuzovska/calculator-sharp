using System.ComponentModel.DataAnnotations;
namespace App
{
    public class Distance
    {
        [Required]
        public int Start { get; }

        [Required]
        public double Price { get; }

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

