namespace TronLink.Blazor.Responses;

public abstract class BlockResponse
{
    public string BlockID { get; set; }
    public BlockHeaderInternal BlockHeader { get; set; }
    
    public class BlockHeaderInternal
    {
        public RawDataInternal RawData { get; set; }
        public string WitnessSignature { get; set; }
    }
    
    public class RawDataInternal
    {
        public long Number { get; set; }
        public string TxTrieRoot { get; set; }
        public string WitnessAddress { get; set; }
        public string ParentHash { get; set; }
        public long Timestamp { get; set; }
    }
}

