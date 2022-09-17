using Xunit;
using App;
using System.Collections.Generic;

namespace Tests;

public class CalculatorTest
{
    [Fact]
    public void calcPrice()
    {
        Calculator calculator = new Calculator();


        List<Distance> distances = new List<Distance>();

        double result;
        result = calculator.calcPrice(distances, 305);
        Assert.Equal(305 * 100, result);

        distances.Add(new Distance(100, 80));
        result = calculator.calcPrice(distances, 305);
        Assert.Equal(100 * 100 + 205 * 80, result);

        distances.Add(new Distance(300, 70));
        result = calculator.calcPrice(distances, 305);
        Assert.Equal(100 * 100 + 200 * 80 + 5 * 70, result);
    }
}