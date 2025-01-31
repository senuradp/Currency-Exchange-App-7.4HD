using System.Collections.Generic;
using System.Text.Json.Serialization;

public class ExchangeRateResponse
{
    // map JSON properties of the api response to C# properties using attributes.

    // maps to base_code
    [JsonPropertyName("base_code")]
    public string? Base { get; set; } 

    // maps to rates
    [JsonPropertyName("rates")]
    public Dictionary<string, decimal>? Rates { get; set; } 

    // maps to result
    [JsonPropertyName("result")]
    public string? Result { get; set; } 

    // maps to time_last_update_utc
    [JsonPropertyName("time_last_update_utc")]
    public string? LastUpdateUtc { get; set; } 

    // maps to time_next_update_utc
    [JsonPropertyName("time_next_update_utc")]
    public string? NextUpdateUtc { get; set; } 
}
