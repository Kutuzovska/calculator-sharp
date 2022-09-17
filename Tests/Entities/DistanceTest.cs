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
}