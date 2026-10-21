using BlazorWasmBrasilApiCep;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// BaseAddress continua sendo o próprio site: se fosse trocado para a BrasilAPI, a página
// Weather (que lê "sample-data/weather.json" do próprio site) quebraria.
// A Home chama a BrasilAPI com URL absoluta; a API tem CORS liberado, então funciona direto do navegador.
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
