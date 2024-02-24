using TronLink.Blazor.Responses.Classes;

namespace TronLink.Blazor.Responses;

public class ApprovedListResponse
{
    public Result Result { get; set; }
    public List<string> ApprovedList { get; set; }
    public TransactionInfo Transaction { get; set; }
}