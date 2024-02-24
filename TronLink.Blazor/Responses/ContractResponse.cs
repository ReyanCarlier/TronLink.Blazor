using System.Text.Json;

namespace TronLink.Blazor.Responses;

public class ContractResponse
{
    public string Bytecode { get; set; }
    public string Name { get; set; }
    public string OriginAddress { get; set; }
    public JsonElement Abi { get; set; } // Utilisation de JsonElement pour une flexibilité maximale
    public string ContractAddress { get; set; }
}