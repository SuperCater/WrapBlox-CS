using Newtonsoft.Json;

namespace WrapBlox.Legacy.Models.Users;
/// <summary>
/// A user roles response model.
/// </summary>
public record UserRolesResponse {
	/// <summary>
	/// The user's roles.
	/// </summary>
	[JsonProperty("roles")]
	public required string[] Roles { get; init; }
}