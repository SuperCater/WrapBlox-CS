using Newtonsoft.Json;

namespace WrapBlox.Legacy.Models;

public record ApiPageResponse<T>(
    [JsonProperty("previousPageCursor")]
    string PreviousPageCursor,
    
    [JsonProperty("nextPageCursor")]
    string NextPageCursor,
    
    [JsonProperty("data")]
    T[] Data
);