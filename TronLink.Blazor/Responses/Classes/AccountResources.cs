namespace TronLink.Blazor.Responses.Classes;

public abstract class AccountResources
{
    public int FreeNetLimit { get; set; }
    public int NetLimit { get; set; }
    public List<AssetNetUsed> AssetNetUsed { get; set; }
    public List<AssetNetLimit> AssetNetLimit { get; set; }
    public long TotalNetLimit { get; set; }
    public int TotalNetWeight { get; set; }
    public long EnergyLimit { get; set; }
    public long TotalEnergyLimit { get; set; }
    public int TotalEnergyWeight { get; set; }
}

public abstract class AssetNetUsed : AssetV2 {  }

public abstract class AssetNetLimit : AssetV2  {  }