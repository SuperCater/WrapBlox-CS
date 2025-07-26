using System.ComponentModel.DataAnnotations;
using WrapBlox.Core;
using WrapBlox.Interfaces;

namespace WrapBlox.Legacy;

public class LegacyUser : IRobloxEntity, IIdentifiable<ulong>, IUser
{
    public string BaseUrl { get; } = UrlConstructor.LegacyConstructor("users");
    public Session? Session { get; set; }
    
    public ulong Id { get; }
    public string Name { get; }
    public string DisplayName { get; }
    
    public bool IsBanned { get; }
    public bool HasVerifiedBadge { get; }
    public DateTimeOffset Created { get; }
    
    [MaxLength(1000)]
    public string Description { get; }

    public string Url => $"{UrlConstructor.RobloxWwwUrl}/users/{Id}";
}