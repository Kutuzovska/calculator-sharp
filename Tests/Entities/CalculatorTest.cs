using Xunit;
using App;
using System.Collections.Generic;

namespace Tests;

public class CalculatorTest
{
    [Fact]
    public void CalcPrice()
    {
        Calculator calculator = new Calculator();


        List<Distance> distances = new List<Distance>();

        double result;
        result = calculator.CalcPrice(distances, 305);
        Assert.Equal(305 * 100, result);

        distances.Add(new Distance(100, 80));
        result = calculator.CalcPrice(distances, 305);
        Assert.Equal(100 * 100 + 205 * 80, result);

        distances.Add(new Distance(300, 70));
        result = calculator.CalcPrice(distances, 305);
        Assert.Equal(100 * 100 + 200 * 80 + 5 * 70, result);
    }

    [Fact]
    public void CalcLittleDistantion()
    {
        Calculator calculator = new Calculator();
        List<Distance> distances = new List<Distance>();

        double result;
        result = calculator.CalcPrice(distances, 1);
        Assert.Equal(100, result);

        distances.Add(new Distance(0, 10));
        result = calculator.CalcPrice(distances, 1);
        Assert.Equal(10, result);
    }
}