using Newtonsoft.Json;

namespace WrapBlox.Legacy.Models.Users;

/// <summary>
/// The request to change a user's set gender. 🏳️‍⚧️
/// </summary>
public record GenderRequest {
	/// <summary>
	/// The user's gender.
	/// </summary>
	[JsonProperty("gender")]
	public required string Gender { get; init; }
}