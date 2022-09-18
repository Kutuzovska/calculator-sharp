using System.Collections.Generic;
using ccalc.Entities;
using Xunit;

namespace Tests;

public class CalculatorTest
{
    [Fact]
    public void CalcPrice()
    {
        var distances = new List<Distance>();

        var result = Calculator.CalcPrice(distances, 305);
        Assert.Equal(305 * 100, result);

        distances.Add(new Distance(100, 80));
        result = Calculator.CalcPrice(distances, 305);
        Assert.Equal(100 * 100 + 205 * 80, result);

        distances.Add(new Distance(300, 70));
        result = Calculator.CalcPrice(distances, 305);
        Assert.Equal(100 * 100 + 200 * 80 + 5 * 70, result);
    }

    [Fact]
    public void CalcLittleDistance()
    {
        var distances = new List<Distance>();

        var result = Calculator.CalcPrice(distances, 1);
        Assert.Equal(100, result);

        distances.Add(new Distance(0, 10));
        result = Calculator.CalcPrice(distances, 1);
        Assert.Equal(10, result);
    }
}