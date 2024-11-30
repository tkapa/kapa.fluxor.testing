using Fluxor;
using Fluxor.Blazor.Web.ReduxDevTools;
using Kapa.Fluxor.Testing.Client.Layout;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddFluxor(options =>
{
    options
        .ScanAssemblies(typeof(MainLayout).Assembly)
        .UseReduxDevTools();
});

await builder.Build().RunAsync();