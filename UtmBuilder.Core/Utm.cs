
using UtmBuilder.Core.ExtensionMethods;
using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core;

public class Utm
{
    public Utm(Url url, Campaign campaign)
    {
        Url = url;
        Campaign = campaign;
    }

    /// <summary>
    /// URL(Website link)
    /// </summary>
    public Url Url { get; }

    /// <summary>
    /// Campaign Details
    /// </summary>
    public Campaign Campaign { get; }

    public override string ToString()
    {
        var segments = new List<string>();

        return $"{Url.Address}?{string.Join("&", segments)}";
    }
}