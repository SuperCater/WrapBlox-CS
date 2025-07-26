using WrapBlox.Enums;
using WrapBlox.Interfaces;
using WrapBlox.Utils;

namespace WrapBlox.Core;

/// <summary>
/// 
/// </summary>
public sealed class Session
{
    public bool IsAuthenticated { get; private set; }
    public AuthenticationScheme? AuthenticationScheme { get; private set; }
    public DateTimeOffset? AuthenticatedAt { get; private set; }
    
    public SessionOptions Options { get; } = new SessionOptions();
    
    public IUser? AuthenticatedUser { get; private set; }
    internal string? Cookie { get; private set; }
    internal string? CsrfToken { get; private set; }
    
    internal string? ApiKey { get; private set; }

    public async Task LoginAsync(AuthenticationScheme scheme, string secret, bool validate = true)
    {
        if (IsAuthenticated)
            throw new InvalidOperationException("This session is already authenticated, call LogoutAsync before logging in again.");
        
        if (validate)
            SessionUtils.ValidateSecret(scheme, secret);
        
        switch (scheme)
        {
            case Enums.AuthenticationScheme.Cookie:
                // TODO: Add logic for cookie authentication
                break;
            
            case Enums.AuthenticationScheme.ApiKey:
                // TODO: Add logic for API key authentication
                break;
            
            default:
                throw new  ArgumentOutOfRangeException(nameof(scheme), scheme, "Unrecognized scheme.");
        }
        
        AuthenticationScheme = scheme;
        AuthenticatedAt = DateTimeOffset.Now;
        IsAuthenticated = true;
        
        // bla bla
    }

    public void LogoutAsync()
    {
        AuthenticationScheme = null;
        AuthenticatedAt = null;
        IsAuthenticated = false;

        AuthenticatedUser = null;
        Cookie = null;
        CsrfToken = null;
        
        ApiKey = null;
    }
}