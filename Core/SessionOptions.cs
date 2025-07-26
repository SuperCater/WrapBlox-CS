namespace WrapBlox.Core;

public class SessionOptions
{
    /// <summary>
    /// Gets or sets a proxy URL to use that will replace 'roblox.com', or <see langword="null"/> to use no proxy. Defaults to <see langword="null"/>.
    /// </summary>
    public string? ProxyUrl { get; set; } = null;
}