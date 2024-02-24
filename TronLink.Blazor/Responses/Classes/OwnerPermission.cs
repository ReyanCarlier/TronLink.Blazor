namespace TronLink.Blazor.Responses.Classes;

public abstract class OwnerPermission
{
    public required string PermissionName { get; set; }
    public int Threshold { get; set; }
    public required List<Key> Keys { get; set; }
}