using Microsoft.Extensions.Hosting;
using SuperSocket.Kestrel;
using SuperSocket.ProtoBase;
using SuperSocket.Server;
using SuperSocket.Server.Host;

await SuperSocketHostBuilder.Create<TextPackageInfo, LinePipelineFilter>()
    .UsePackageHandler(packageHandler: async (session, package) =>
    {
        await ValueTask.CompletedTask;
    })
    .UseClearIdleSession()
    .UseInProcSessionContainer()
    .UseKestrelPipeConnection()
    .Build()
    .RunAsync();