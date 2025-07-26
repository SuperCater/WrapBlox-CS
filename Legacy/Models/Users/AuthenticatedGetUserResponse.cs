using Newtonsoft.Json;

namespace WrapBlox.Legacy.Models.Users;

/// <summary>
/// A response model representing absolute minimal authenticating user information.
/// No new attributes should be added to this response since it is in the critical path of app launch and we want to minimize dependencies.
/// 

public record AuthenticatedGetUserResponse {
	/// <summary>
	/// The user's ID.
	/// </summary>
	[JsonProperty("id")]
	public required ulong Id { get; init; }
	
	/// <summary>
	/// The user's name.
	/// </summary>
	[JsonProperty("name")]
	public required string Name { get; init; }
	
	/// <summary>
	/// The user's display name.
	/// </summary>
	[JsonProperty("displayName")]
	public required string DisplayName { get; init; }
}