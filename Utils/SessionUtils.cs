using WrapBlox.Enums;

namespace WrapBlox.Utils;

public static class SessionUtils
{
    private const string CookiePrefix = "_|WARNING:-DO-NOT-SHARE-THIS.--Sharing-this-will-allow-someone-to-log-in-as-you-and-to-steal-your-ROBUX-and-items.|_";
    
    public static void ValidateSecret(AuthenticationScheme scheme, string secret)
    {
        ArgumentNullException.ThrowIfNullOrWhiteSpace(secret);

        switch (scheme)
        {
            case AuthenticationScheme.Cookie:
                if (!secret.StartsWith(CookiePrefix))
                    throw new ArgumentException("The .ROBLOSECURITY cookie must be provided in full.");
                
                break;
            
            case AuthenticationScheme.ApiKey:
                break;
            
            default:
                throw new ArgumentOutOfRangeException(nameof(scheme), scheme, "Unrecognized scheme.");
        }
    }
}