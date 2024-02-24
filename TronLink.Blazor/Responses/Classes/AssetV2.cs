namespace TronLink.Blazor.Responses.Classes;

public abstract class AssetV2
{
    public required string Key { get; set; }
    public long Value { get; set; }
}