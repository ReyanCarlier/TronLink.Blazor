namespace TronLink.Blazor.Responses.Classes;

public abstract class FrozenBalanceForEnergy
{
    public long FrozenBalance { get; set; }
    public long ExpireTime { get; set; }
}