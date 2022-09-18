namespace ccalc.Entities.Exceptions;

[Serializable]
public class DistanceInvalidCreateException : Exception
{
    public DistanceInvalidCreateException(string message) : base(message)
    {
    }
}