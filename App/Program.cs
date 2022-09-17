namespace App
{
    using System;

    class Program
    {
        public static void Main()
        {
            Distance distance = new Distance(0, 10);
            Console.WriteLine(distance.Start);
            Console.WriteLine(distance.Price);
        }
    }
}

