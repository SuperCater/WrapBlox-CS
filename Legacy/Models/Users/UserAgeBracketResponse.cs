using Newtonsoft.Json;
using WrapBlox.Legacy.Enums;

namespace WrapBlox.Legacy.Models.Users;
/// <summary>
/// The response model for the age bracket of a user.
/// </summary>
public record UserAgeBracketResponse {
	/// <summary>
	/// The age bracket of the user.
	/// </summary>
	[JsonProperty("ageBracket")]
	public AgeBracket AgeBracket { get; init; }
}