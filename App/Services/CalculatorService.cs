namespace App
{
    public class CalculatorService
    {
        private readonly IDistancesRepository repository;

        public CalculatorService(IDistancesRepository repository)
        {
            this.repository = repository;
        }

        public double calculateDistancePrice(int distance)
        {
            List<Distance> distances = repository.all();
            Calculator calculator = new Calculator();
            return calculator.calcPrice(distances, distance);
        }
    }
}