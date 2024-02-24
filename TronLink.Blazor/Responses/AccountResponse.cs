using TronLink.Blazor.Responses.Classes;

namespace TronLink.Blazor.Responses;

public class AccountResponse
{
    public required string Address { get; set; }
    public long Balance { get; set; }
    public required List<Frozen> Frozen { get; set; }
    public long CreateTime { get; set; }
    public long LatestOperationTime { get; set; }
    public long LatestConsumeFreeTime { get; set; }
    public required AccountResources AccountResources { get; set; }
    public required OwnerPermission OwnerPermission { get; set; }
    public required List<ActivePermission> ActivePermission { get; set; }
    public required List<AssetV2> AssetV2 { get; set; }
    public required List<FreeAssetNetUsageV2> FreeAssetNetUsageV2 { get; set; }
}