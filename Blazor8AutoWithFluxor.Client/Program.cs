using Fluxor;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddFluxor(options =>
{
    options.ScanAssemblies(typeof(Blazor8AutoWithFluxor.Shared.State.Counter.CounterState).Assembly);
});

await builder.Build().RunAsync();
