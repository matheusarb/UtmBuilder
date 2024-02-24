namespace UtmBuilder.Core.ValueObjects.Exceptions;

public class InvalidCampaignException : Exception
{
    private const string DefaultErrorMessage = "Invalid item";

    public InvalidCampaignException(string message = DefaultErrorMessage)
    : base(message)
    {
    }

    public static void ThrowIfNullOrInvalid(
        string? item,
        string message = DefaultErrorMessage)
    {
        if(string.IsNullOrEmpty(item))
            throw new InvalidCampaignException(message);
    }
}