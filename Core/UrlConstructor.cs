namespace WrapBlox.Core;

public static class UrlConstructor
{
    public const string RobloxUrl = "https://roblox.com";
    public const string RobloxWwwUrl = "https://www.roblox.com";
    
    public const string RobloxFormatUrl = "https://{0}.roblox.com";
    
    public const string OpenCloudUrl = "https://apis.roblox.com";
    public const string OpenCloudFormatUrl  = "https://apis.roblox.com/{0}";

    public static string LegacyConstructor(string subdomain)
        => string.Format(RobloxFormatUrl, subdomain);

    public static string OpenCloudV1Constructor(string api)
        => string.Format(OpenCloudFormatUrl, api);

    public static string OpenCloudV2Constructor(string api)
        => string.Format(OpenCloudFormatUrl, $"/cloud/v2/{api}");
}