using Newtonsoft.Json;

namespace WrapBlox.Legacy.Models.Users;
/// <summary>
/// The response model for a user's country code.
/// </summary>
public record UserCountryCodeResponse {
	/// <summary>
	/// The country code of the user.
	/// </summary>
	[JsonProperty("countryCode")]
	public required string CountryCode { get; init; }
}