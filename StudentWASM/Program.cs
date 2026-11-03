using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using StudentWASM;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

string apiUrl = "/api/";
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(apiUrl)
});


await builder.Build().RunAsync();
