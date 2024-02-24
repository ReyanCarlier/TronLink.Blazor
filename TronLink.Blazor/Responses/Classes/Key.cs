namespace TronLink.Blazor.Responses.Classes;

public abstract class Key
{
    public required string Address { get; set; }
    public int Weight { get; set; }
}