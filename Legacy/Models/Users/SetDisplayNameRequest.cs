using Newtonsoft.Json;

namespace WrapBlox.Legacy.Models.Users;

/// <summary>
/// A request model for setting a user's display name.
/// </summary>
public record SetDisplayNameRequest {
	/// <summary>
	/// The new display name for the user.
	/// </summary>
	[JsonProperty("newDisplayName")]
	public required string NewDisplayName { get; init; }
}