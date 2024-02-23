using System.Numerics;
using System.Transactions;
using Nethereum.ABI.FunctionEncoding;
using Nethereum.ABI.Model;
using Nethereum.JsonRpc.Client;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.RPC.Eth.Transactions;

namespace TronLink.Blazor.Extensions;

public static class SendTransactionExtensions
{
    private static async Task<string> CallFunction(ITronLinkService tronLink, string functionName, string contractAddress, BigInteger amountInWei, Parameter[] parameters, params object[] args)
    {
        FunctionABI function = new(functionName, false)
        {
            InputParameters = parameters
        };

        FunctionCallEncoder functionCallEncoder = new();

        string data = functionCallEncoder.EncodeRequest(function.Sha3Signature, parameters, args);
        data = data[2..];

        var result = await tronLink.SendTransaction(contractAddress, Convert.ToDecimal(amountInWei), data);
        return result;
    }
    
    private static async Task<TransactionReceipt> GetTransactionReceipt(string txHash, IClient client, int interval = 1000)
    {
        
        EthGetTransactionReceipt getTransactionReceipt = new(client);
        TransactionReceipt? receipt = null;
        while (receipt == null)
        {
            receipt = await getTransactionReceipt.SendRequestAsync(txHash);
            await Task.Delay(interval);
        }
        return receipt;
    }

    /// <summary>
    /// Send transaction to smart contract and wait for receipt
    /// </summary>
    /// <param name="tronLink"></param>
    /// <param name="client">Web3 Client</param>
    /// <param name="funcName">Function To Call</param>
    /// <param name="contractAddress">Smart Contract Address</param>
    /// <param name="value">Value In Wei</param>
    /// <param name="inputParams">Function Parameters</param>
    /// <param name="values">Function Values</param>
    /// <returns>Receipt Of Transaction</returns>
    public static async Task<TransactionReceipt> SendTransactionAndWaitForReceipt(this ITronLinkService tronLink, IClient client, string funcName, string contractAddress, BigInteger value, Parameter[] inputParams, params object[] values)
    {
        var txHash = await CallFunction(tronLink, funcName, contractAddress, value, inputParams, values);
        var receipt = await GetTransactionReceipt(txHash, client);
        return receipt;
    }

    /// <summary>
    /// Send transaction to smart contract and wait for receipt
    /// </summary>
    /// <param name="tronLink"></param>
    /// <param name="client">Web3 Client</param>
    /// <param name="funcName">Function To Call</param>
    /// <param name="contractAddress">Smart Contract Address</param>
    /// <param name="value">Value In Wei</param>
    /// <param name="inputParams">Function Parameters</param>
    /// <param name="values">Function Values</param>
    /// <param name="interval">The interval at which we check for a transaction receipt</param>
    /// <returns>Receipt Of Transaction</returns>
    public static async Task<TransactionReceipt> SendTransactionAndWaitForReceipt (this ITronLinkService tronLink, IClient client, string funcName, string contractAddress, BigInteger value, Parameter[] inputParams, int interval = 1000, params object[] values)
    {
        var txHash = await CallFunction(tronLink, funcName, contractAddress, value, inputParams, values);
        return await GetTransactionReceipt(txHash, client, interval);
    }
}