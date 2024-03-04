# TronLink.Blazor

TronLink.Blazor is a library designed for Blazor WebAssembly (WASP) projects to interact with the Tron blockchain via the TronLink extension. It enables your Blazor applications to communicate with the Tron network, manage accounts, execute transactions, and query blockchain data in a secure and user-friendly way.

## Prerequisites

Before you start using TronLink.Blazor, make sure you have the following:

- .NET 8.0 SDK or later installed on your machine.
- An existing Blazor WebAssembly project or the knowledge to create one.
- The TronLink browser extension installed in your browser for interacting with the Tron blockchain.
- Basic understanding of Blazor and C# programming.

## Installation

To use TronLink.Blazor in your project, you need to add the library to your project dependencies:

1. Open your Blazor WASP project in your preferred IDE.
2. Edit your project's `.csproj` file to include the following package references:

    ```xml
    <ItemGroup>
        <PackageReference Include="Microsoft.AspNetCore.Components.Web" Version="8.0.0"/>
        <PackageReference Include="Nethereum.ABI" Version="4.19.0" />
        <PackageReference Include="Nethereum.JsonRpc.Client" Version="4.19.0" />
        <PackageReference Include="Nethereum.RPC" Version="4.19.0" />
    </ItemGroup>
    ```

3. Save the changes and restore the packages to ensure they are correctly installed in your project.

## Configuration

After installing the necessary packages, you need to configure your Blazor application to use TronLink.Blazor:

1. Open the `Program.cs` file or wherever you configure your services.
2. Add the TronLink service to the service collection:

    ```csharp
    builder.Services.AddTronLinkBlazor();
    ```

3. Save your changes.

## Usage

To use TronLink.Blazor in your components, you need to follow these steps:

1. Inject the TronLink service into your Blazor components:

    ```csharp
    @inject ITronLinkService TronLinkService
    ```

2. Use the TronLink service methods to interact with the Tron blockchain. For example, to connect to the TronLink wallet:

    ```csharp
    await TronLinkService.ConnectTronLink();
    ```

3. You can now use other methods to interact with the Tron network, such as `GetBalance`, `SendTransaction`, or `TriggerSmartContract`.

## Events

TronLink.Blazor provides events that you can subscribe to for reacting to changes such as account changes or chain changes:

```csharp
TronLinkService.AccountChangedEvent += async (string newAccount) => {
    // Handle the account change
};

TronLinkService.ChainChangedEvent += async (string newChainId) => {
    // Handle the chain change
};
```

Make sure to unsubscribe from these events when the component is disposed to avoid memory leaks.

## Disposal

Properly dispose the TronLink service when your component is being disposed to clean up resources:

```csharp
@implements IDisposable

protected async ValueTask DisposeAsync()
{
    await TronLinkService.DisposeAsync();
}
```

## Example

Here's a simple example of a Blazor component that connects to the TronLink wallet and displays the current account address:

```csharp
@page "/tronlink-example"
@inject ITronLinkService TronLinkService

<h1>TronLink Example</h1>
<button @onclick="ConnectWallet">Connect TronLink Wallet</button>
@if (!string.IsNullOrEmpty(currentAddress))
{
    <p>Current Address: @currentAddress</p>
}

@code {
    private string currentAddress = string.Empty;

    private async Task ConnectWallet()
    {
        await TronLinkService.ConnectTronLink();
        currentAddress = await TronLinkService.GetSelectedAddress();
    }
}
```

## Support

For issues, questions, or contributions, please refer to the project's GitHub repository.
This project is currently under development, thus, don't hesitate to create PR.

Enjoy building with TronLink.Blazor and the Tron blockchain!