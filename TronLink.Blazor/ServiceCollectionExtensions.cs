using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;

namespace TronLink.Blazor;

public static class ServiceCollectionExtensions
{
    public static void AddTronLinkBlazor(this IServiceCollection services)
    {
        services.AddScoped<ITronLinkService>(sp => new TronLinkService(sp.GetRequiredService<IJSRuntime>()));
    }
}