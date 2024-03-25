namespace cw3;

public class InvalidContainerException : Exception
{
    public InvalidContainerException()
    {
    }

    public InvalidContainerException(string? message) : base(message)
    {
    }
}