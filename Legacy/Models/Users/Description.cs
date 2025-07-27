using Newtonsoft.Json;

namespace WrapBlox.Legacy.Models.Users;

// This is the request and response model for the description of a user. They are the same.
/// <summary>
/// The request and response model for the description of a user.
/// </summary>
public record DescriptionRequest {
	/// <summary>
	/// The description of the user.
	/// </summary>
	[JsonProperty("description")]
	public required string Description { get; init; }
}