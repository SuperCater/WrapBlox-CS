using Newtonsoft.Json;

namespace WrapBlox.Legacy.Models.Users;
/// <summary>
/// A response model for a user's information.
/// </summary>
public record GetUserResponse : AuthenticatedGetUserResponse {
	
	/// <summary>
	/// The user's description.
	/// </summary>
	[JsonProperty("description")]
	public required string Description { get; init; }
	
	/// <summary>
	/// When the user signed up.
	/// </summary>
	[JsonProperty("created")]
	public required string Created { get; init; }
	
	/// <summary>
	/// Whether the user is banned
	/// </summary>
	[JsonProperty("isBanned")]
	public required bool IsBanned { get; init; }
	
	/// <summary>
	/// Unused, legacy attribute. For now always null to not disturb existing client code that might rely on its existence.
	/// </summary>
	[JsonProperty("externalAppDisplayName", NullValueHandling = NullValueHandling.Ignore)]
	public string? ExternalAppDisplayName { get; init; }
	
	/// <summary>
	/// The user's verified badge status.
	/// </summary>
	[JsonProperty("hasVerifiedBadge")]
	public required bool HasVerifiedBadge { get; init; }
};