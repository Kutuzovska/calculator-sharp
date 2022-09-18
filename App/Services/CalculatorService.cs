namespace App
{
    public class CalculatorService : ICalculatorService
    {
        private readonly IDistancesRepository repository;

        public CalculatorService(IDistancesRepository repository)
        {
            this.repository = repository;
        }

        public double CalculateDistancePrice(int distance)
        {
            List<Distance> distances = repository.All();
            Calculator calculator = new Calculator();
            return calculator.CalcPrice(distances, distance);
        }
    }
}