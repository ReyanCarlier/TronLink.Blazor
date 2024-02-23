using Microsoft.JSInterop;

namespace TronLink.Blazor;

// This class can be registered as scoped DI service and then injected into Blazor
// components for use.

public class TronLinkService : IAsyncDisposable, ITronLinkService
{
    private readonly Lazy<Task<IJSObjectReference>> _moduleTask;

    public static event Func<string, Task>? AccountChangedEvent;
    public static event Func<string, Task>? ChainChangedEvent;

    public static event Action? OnConnectEvent;
    public static event Action? OnDisconnectEvent;

    public TronLinkService(IJSRuntime jsRuntime)
    {
        _moduleTask = new Lazy<Task<IJSObjectReference>>(() => LoadScripts(jsRuntime).AsTask());
    }
    
    public async ValueTask<IJSObjectReference> LoadScripts(IJSRuntime jsRuntime)
    {
        return await jsRuntime.InvokeAsync<IJSObjectReference>("import", "./_content/TronLink.Blazor/tronLinkJsInterop.js");
    }
    
    public async ValueTask ConnectTronLink()
    {
        var module = await _moduleTask.Value;
        await module.InvokeVoidAsync("connectTronLink");
    }
    
    public async ValueTask DisposeAsync()
    {
        if (_moduleTask.IsValueCreated)
        {
            var module = await _moduleTask.Value;
            await module.DisposeAsync();
        }
    }
    
    public async ValueTask<dynamic> GenericRpc(string method, params dynamic[]? args)
    {
        var module = await _moduleTask.Value;
        return await module.InvokeAsync<dynamic>("genericRpc", method, args);
    }
    
    public async Task<decimal> GetBalance(string address, string block = "latest")
    {
        var module = await _moduleTask.Value;
        return await module.InvokeAsync<decimal>("getBalance", address, block);
    }
    
    public async ValueTask<string> GetSelectedAddress()
    {
        var module = await _moduleTask.Value;
        return await module.InvokeAsync<string>("getSelectedAddress");
    }
    
    public async ValueTask<string> GetSelectedChain()
    {
        var module = await _moduleTask.Value;
        return await module.InvokeAsync<string>("getSelectedChain");
    }
    
    public async ValueTask<long> GetTransactionCount()
    {
        var module = await _moduleTask.Value;
        return await module.InvokeAsync<long>("getTransactionCount");
    }
    
    public async ValueTask<bool> HasTronLink()
    {
        var module = await _moduleTask.Value;
        return await module.InvokeAsync<bool>("hasTronLink");
    }
    
    public async ValueTask<bool> IsSiteConnected()
    {
        var module = await _moduleTask.Value;
        return await module.InvokeAsync<bool>("isSiteConnected");
    }
    
    public async ValueTask ListenToEvents()
    {
        var module = await _moduleTask.Value;
        await module.InvokeVoidAsync("listenToEvents", DotNetObjectReference.Create(this));
    }
    
    public async Task<string> RequestAccounts()
    {
        var module = await _moduleTask.Value;
        return await module.InvokeAsync<string>("requestAccounts");
    }
    
    public async ValueTask<string> SendTransaction(string to, decimal amount, string? data = null)
    {
        var module = await _moduleTask.Value;
        return await module.InvokeAsync<string>("sendTransaction", to, amount, data);
    }
    
    public async ValueTask<string> TriggerSmartContract(string contractAddress, string functionSelector, string parameter, decimal amount)
    {
        var module = await _moduleTask.Value;
        return await module.InvokeAsync<string>("triggerSmartContract", contractAddress, functionSelector, parameter, amount);
    }
    
    [JSInvokable()]
    public static void OnConnect()
    {
        OnConnectEvent?.Invoke();
    }
    
    [JSInvokable()]
    public static void OnDisconnect()
    {
        OnDisconnectEvent?.Invoke();
    }
    
    [JSInvokable()]
    public static async Task OnAccountsChanged(string selectedAccount)
    {
        if (AccountChangedEvent != null)
        {
            await AccountChangedEvent(selectedAccount);
        }
    }
    
    [JSInvokable()]
    public static async Task OnChainChanged(string chainId)
    {
        if (ChainChangedEvent != null)
        {
            await ChainChangedEvent(chainId);
        }
    }
}