
using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core;

public class Utm
{
    public Url Url { get; set; } = new();
    public Campaign Campaign { get; set; } = new();

}