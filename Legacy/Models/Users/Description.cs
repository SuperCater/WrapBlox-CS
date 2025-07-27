using Newtonsoft.Json;

namespace WrapBlox.Legacy.Models.Users;

/// <summary>
/// The request and response model for the description of a user.
/// <remarks>This is the request and response model for the description of a user. They are the same.</remarks>
/// </summary>
public record DescriptionRequest {
	/// <summary>
	/// The description of the user.
	/// </summary>
	[JsonProperty("description")]
	public required string Description { get; init; }
}
