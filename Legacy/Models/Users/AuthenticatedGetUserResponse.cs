using Newtonsoft.Json;

namespace WrapBlox.Legacy.Models.Users;

public record AuthenticatedGetUserResponse {
	[JsonProperty("id")]
	public required ulong Id { get; init; }
	
	[JsonProperty("name")]
	public required string Name { get; init; }
	
	[JsonProperty("displayName")]
	public required string DisplayName { get; init; }
}