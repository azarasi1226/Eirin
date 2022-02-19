using Eirin.Client;
using Grpc.Net.Client;
using Grpc.Net.Client.Web;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// gRPCƒ`ƒƒƒ“ƒlƒ‹‚Ì“o˜^
builder.Services.AddScoped(services =>
{
    var config = services.GetRequiredService<IConfiguration>();
    var gRPCUri = config["gRPC_URI"];

    return GrpcChannel.ForAddress(gRPCUri, new GrpcChannelOptions
    {
        HttpHandler = new GrpcWebHandler(GrpcWebMode.GrpcWeb, new HttpClientHandler()),
    });
});

await builder.Build().RunAsync();
