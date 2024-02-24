namespace TronLink.Blazor.Responses.Classes;

public abstract class Frozen
{
    public long FrozenBalance { get; set; }
    public long ExpireTime { get; set; }
}