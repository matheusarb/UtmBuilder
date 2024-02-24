namespace UtmBuilder.Core.ValueObjects;

public class Campaign : ValueObject
{
    public Campaign(
        string source,
        string medium,
        string name,
        string? id = null,
        string? term = null,
        string? content = null)
    {
        Source = source;
        Medium = medium;
        Name = name;
        Id = id;
        Term = term;
        Content = content;
    }

    /// <summary>
    /// The referrer (e.g. google, newsletter)
    /// </summary>
    public string Source { get; set; }
    public string Medium { get; set; }
    public string Name { get; set; }

    /// <summary>
    /// The ads campaign id.
    /// </summary>
    public string? Id { get; set; }

    public string? Term { get; set; }
    public string? Content { get; set; }
}