using Newtonsoft.Json;

namespace WrapBlox.Legacy.Models.Users;

/// <summary>
/// A response model specific to multi-get user by name.
/// </summary>
public record MultiGetUserByNameResponse : AuthenticatedGetUserResponse {
	/// <summary>
	/// The username used for the request.
	/// </summary>
	[JsonProperty("requestedUsername")]
	public required string RequestedUsername { get; init; }
	
	/// <summary>
	/// The user's verified badge status.
	/// </summary>
	[JsonProperty("hasVerifiedBadge")]
	public required bool HasVerifiedBadge { get; init; }
	
	
};