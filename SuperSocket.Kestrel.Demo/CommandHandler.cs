using SuperSocket.ProtoBase;
using SuperSocket.Server.Abstractions;
using SuperSocket.Server.Abstractions.Session;

namespace SuperSocket.Kestrel.Demo;

public sealed class CommandHandler : IPackageHandler<TextPackageInfo>
{
    public ValueTask Handle(IAppSession session, TextPackageInfo package, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Package Received: {package}");
        return ValueTask.CompletedTask;
    }
}