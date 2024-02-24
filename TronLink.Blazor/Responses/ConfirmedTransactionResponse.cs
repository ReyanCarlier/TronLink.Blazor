namespace TronLink.Blazor.Responses;

public class ConfirmedTransactionResponse
{
    public List<RetConfirmedTransactionResponse> Ret { get; set; }
    public List<string> Signature { get; set; }
    public string TxID { get; set; }
    public RawDataConfirmedTransactionResponse RawData { get; set; }
    public string RawDataHex { get; set; }
    public class RetConfirmedTransactionResponse
    {
        public string ContractRet { get; set; }
    }

    public class RawDataConfirmedTransactionResponse
    {
        public List<Contract> Contract { get; set; }
        public string RefBlockBytes { get; set; }
        public string RefBlockHash { get; set; }
        public long Expiration { get; set; }
        public long FeeLimit { get; set; }
        public long Timestamp { get; set; }
    }

    public class Contract
    {
        public Parameter Parameter { get; set; }
        public string Type { get; set; }
    }

    public class Parameter
    {
        public Value Value { get; set; }
        public string TypeUrl { get; set; }
    }

    public class Value
    {
        public string Data { get; set; }
        public string OwnerAddress { get; set; }
        public string ContractAddress { get; set; }
    }
}


