namespace TronLink.Blazor.Responses.Classes;

public abstract class TransactionInfo
{
    public TransactionResult Result { get; set; }
    public string Txid { get; set; }
    public TransactionDetail Transaction { get; set; }
}