using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using YTool.App;
using YTool.Interface;
using YTool.Service;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBootstrapBlazor();

builder.Services.AddScoped<ITextInterface, TextService>();
builder.Services.AddScoped<IJsonInterface, JsonService>();
builder.Services.AddScoped<IImageInterface, ImageService>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();