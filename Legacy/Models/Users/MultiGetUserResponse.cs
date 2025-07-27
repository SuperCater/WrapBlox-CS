using Newtonsoft.Json;

namespace WrapBlox.Legacy.Models.Users;
/// <summary>
/// A response model specific to multi-get user.
/// </summary>
public record MultiGetUserResponse : AuthenticatedGetUserResponse {
	/// <summary>
	/// The user's verified badge status.
	/// </summary>
	[JsonProperty("hasVerifiedBadge")]
	public required bool HasVerifiedBadge { get; init; }

}