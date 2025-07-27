using Newtonsoft.Json;

namespace WrapBlox.Legacy.Models.Users;

/// <summary>
/// Used to upload a user's birthdate for Roblox.
/// </summary>
public record BirthdateRequest {
	/// <summary>
	/// The user's birth month.
	/// </summary>
	[JsonProperty("birthMonth")]
	public required int BirthMonth { get; init; }
	/// <summary>
	/// The user's birth day of the month.
	/// </summary>
	[JsonProperty("birthDay")]
	public required int BirthDay { get; init; }
	/// <summary>
	/// The user's birth year.
	///	</summary>
	[JsonProperty("birthYear")]
	public required int BirthYear { get; init; }
	/// <summary>
	/// The user's password. This is a security requirement by Roblox.
	/// </summary>
	[JsonProperty("password")]
	public required string Password { get; init; }
}