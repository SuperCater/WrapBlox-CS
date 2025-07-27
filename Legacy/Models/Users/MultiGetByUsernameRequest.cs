using Newtonsoft.Json;

namespace WrapBlox.Legacy.Models.Users;

/// <summary>
/// Request model for getting users by usernames.
/// </summary>
public record MultiGetByUsernameRequest {
	/// <summary>
	/// The usernames of the users to get.
	/// </summary>
	[JsonProperty("usernames")]
	public string[] Usernames { get; init; } = [];
	/// <summary>
	/// Whether to exclude banned users from the response.
	/// </summary>
	[JsonProperty("excludeBannedUsers", NullValueHandling = NullValueHandling.Ignore)]
	public bool? ExcludeBannedUsers { get; init; } = true;
}