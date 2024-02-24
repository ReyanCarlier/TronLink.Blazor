namespace TronLink.Blazor.Responses.Classes;

public abstract class ActivePermission
{
    public required string Type { get; set; }
    public int Id { get; set; }
    public required string PermissionName { get; set; }
    public int Threshold { get; set; }
    public required string Operations { get; set; }
    public required List<Key> Keys { get; set; }
}