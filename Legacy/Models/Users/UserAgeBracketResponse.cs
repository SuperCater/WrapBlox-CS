using Newtonsoft.Json;

namespace WrapBlox.Legacy.Models.Users;

public record UserAgeBracketResponse {
	/// <summary>
	/// The age bracket of the user.
	/// </summary>
	[JsonProperty("ageBracket")]
	public int AgeBracket { get; init; } // TODO: Once documented change to AgeBracketEnum
}