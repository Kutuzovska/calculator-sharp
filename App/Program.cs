namespace App
{
    using System;

    class Program
    {
        public static void Main()
        {
            IDistancesRepository repository = new ArrayDistancesRepository();
            CalculatorService service = new CalculatorService(repository);

            double result = service.calculateDistancePrice(305);
            Console.WriteLine(result);
        }
    }
}

