using Xunit;
using App;

namespace Tests;

public class DistanceTest
{
    [Fact]
    public void CreateDistance()
    {
        Distance distance = new Distance(0, 10);
        Assert.Equal(0, distance.Start);
        Assert.Equal(10, distance.Price);

        Assert.Throws<DistanceInvalidCreateException>(() => new Distance(-1, 10));
        Assert.Throws<DistanceInvalidCreateException>(() => new Distance(10, 0));
    }

    [Fact]
    public void EmptyDistance()
    {
        Distance distance = new Distance { Start = -1, Price = -1 };
        Assert.Equal(-1, distance.Price);
        Assert.Equal(-1, distance.Start);
    }
}