namespace TronLink.Blazor.Responses.Classes;

public abstract class Parameter
{
    public Value Value { get; set; }
    public string TypeUrl { get; set; }
}