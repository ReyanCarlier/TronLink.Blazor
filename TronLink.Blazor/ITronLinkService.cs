using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace TronLink.Blazor
{
    public interface ITronLinkService
    {
        public static event Func<string, Task>? AccountChangedEvent;
        public static event Func<string, Task>? ChainChangedEvent;

        /// <summary>
        /// Événement déclenché lors de la connexion à TronLink.
        /// </summary>
        public static event Action? OnConnectEvent;

        /// <summary>
        /// Événement déclenché lors de la déconnexion de TronLink.
        /// </summary>
        public static event Action? OnDisconnectEvent;

        ValueTask ConnectTronLink();
        ValueTask DisposeAsync();
        ValueTask<dynamic> GenericRpc(string method, params dynamic[]? args);
        Task<decimal> GetBalance(string address, string block = "latest");
        ValueTask<string> GetSelectedAddress();
        ValueTask<string> GetSelectedChain();
        ValueTask<long> GetTransactionCount();
        ValueTask<bool> HasTronLink();
        ValueTask<bool> IsSiteConnected();
        ValueTask ListenToEvents();
        ValueTask<IJSObjectReference> LoadScripts(IJSRuntime jsRuntime);
        Task<string> RequestAccounts();
        ValueTask<string> SendTransaction(string to, decimal amount, string? data = null);
        ValueTask<string> TriggerSmartContract(string contractAddress, string functionSelector, string parameter, decimal amount);
        
        [JSInvokable()]
        static void OnConnect()
        {
            OnConnectEvent?.Invoke();
        }

        [JSInvokable()]
        static void OnDisconnect()
        {
            OnDisconnectEvent?.Invoke();
        }

        [JSInvokable()]
        static async Task OnAccountsChanged(string selectedAccount)
        {
            if (AccountChangedEvent != null)
            {
                await AccountChangedEvent(selectedAccount);
            }
        }

        [JSInvokable()]
        static async Task OnChainChanged(string chainId)
        {
            if (ChainChangedEvent != null)
            {
                await ChainChangedEvent(chainId);
            }
        }
    }
}
