namespace TronLink.Blazor.Responses.Classes;

public abstract class Value
{
    public long Amount { get; set; }
    public string OwnerAddress { get; set; }
    public string ToAddress { get; set; }
}