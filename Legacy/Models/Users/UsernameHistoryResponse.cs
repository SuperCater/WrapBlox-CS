using Newtonsoft.Json;

namespace WrapBlox.Legacy.Models.Users;

/// <summary>
/// A response model for a user's username history.
/// </summary>
public record UsernameHistoryResponse {
	/// <summary>
	/// A user's username history.
	/// </summary>
	[JsonProperty("name")]
	public required string[] Name { get; init; }
}