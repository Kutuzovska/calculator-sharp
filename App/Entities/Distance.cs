using System.Diagnostics.CodeAnalysis;
using ccalc.Entities.Exceptions;

namespace ccalc.Entities;

public class Distance
{
    public Distance()
    {
    }

    [SetsRequiredMembers]
    public Distance(int start, double price)
    {
        if (start < 0)
            throw new DistanceInvalidCreateException("Start position cannot be less than 0");

        if (price <= 0)
            throw new DistanceInvalidCreateException("Too little price");

        Start = start;
        Price = price;
    }

    public required int Start { get; init; }

    public required double Price { get; init; }
}