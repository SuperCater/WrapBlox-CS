using Newtonsoft.Json;

namespace WrapBlox.Legacy.Models.Users;

/// <summary>
/// A user response model specific to getting a user by search.
/// </summary>
public record SearchGetUserResponse : MultiGetUserResponse {
	/// <summary>
	/// A list of previous usernames the user has had.
	/// </summary>
	[JsonProperty("previousUsernames")]
	public required string[] PreviousUsernames { get; init; }
}