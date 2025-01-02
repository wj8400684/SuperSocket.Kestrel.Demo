using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SuperSocket.Kestrel;
using SuperSocket.Kestrel.Demo;
using SuperSocket.ProtoBase;
using SuperSocket.Server;
using SuperSocket.Server.Abstractions;
using SuperSocket.Server.Host;

await SuperSocketHostBuilder.Create<TextPackageInfo, LinePipelineFilter>()
    .UseClearIdleSession()
    .UseInProcSessionContainer()
    .UseKestrelPipeConnection()
    .ConfigureServices((ctx, services) =>
    {
        services.AddSingleton<IPackageHandler<TextPackageInfo>, CommandHandler>();
    })
    .Build()
    .RunAsync();