using Newtonsoft.Json;

namespace WrapBlox.Legacy.Models.Users;

/// <summary>
/// Request model for getting users by ids.
/// </summary>
public record MultiGetByUserIdRequest {
	/// <summary>
	/// The user IDs to get the users for.
	/// </summary>
	[JsonProperty("userIds")]
	public required ulong[] UserIds { get; init; } = [];
	
	/// <summary>
	/// If true, the request will not return users that are banned.
	/// </summary>
	[JsonProperty("excludeBannedUsers", NullValueHandling = NullValueHandling.Ignore)]
	public bool? ExcludeBannedUsers { get; init; } = true;
};