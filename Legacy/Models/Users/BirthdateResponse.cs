using Newtonsoft.Json;

namespace WrapBlox.Legacy.Models.Users;

public record BirthdateResponse {
	/// <summary>
	/// The user's birth month.
	/// </summary>
	[JsonProperty("birthMonth")]
	public required int BirthMonth { get; init; }
	/// <summary>
	/// The user's birth day of the month.
	///	</summary>
	[JsonProperty("birthDay")]
	public required int BirthDay { get; init; }
	/// <summary>
	/// The user's birth year.
	/// </summary>
	[JsonProperty("birthYear")]
	public required int BirthYear { get; init; }
}