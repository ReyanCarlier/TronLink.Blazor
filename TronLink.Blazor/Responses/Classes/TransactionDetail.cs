namespace TronLink.Blazor.Responses.Classes;

public abstract class TransactionDetail
{
    public List<string> Signature { get; set; }
    public string TxID { get; set; }
    private RawDataInternal RawData { get; set; }
    public string RawDataHex { get; set; }
    
    private abstract class RawDataInternal
    {
        public List<Contract> Contract { get; set; }
        public string RefBlockBytes { get; set; }
        public string RefBlockHash { get; set; }
        public long Expiration { get; set; }
        public long Timestamp { get; set; }
    }
}