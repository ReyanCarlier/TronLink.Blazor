using System.Text.Json.Serialization;

namespace TronLink.Blazor.Responses;

public class ExchangeResponse
{
    [JsonPropertyName("exchange_id")]
    public int ExchangeId { get; set; }

    [JsonPropertyName("creator_address")]
    public string CreatorAddress { get; set; }

    [JsonPropertyName("create_time")]
    public long CreateTime { get; set; }

    [JsonPropertyName("first_token_id")]
    public string FirstTokenId { get; set; }

    [JsonPropertyName("first_token_balance")]
    public long FirstTokenBalance { get; set; }

    [JsonPropertyName("second_token_id")]
    public string SecondTokenId { get; set; }

    [JsonPropertyName("second_token_balance")]
    public long SecondTokenBalance { get; set; }
}
