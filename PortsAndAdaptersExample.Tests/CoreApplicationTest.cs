using Moq;

namespace PortsAndAdaptersExample.Tests;

public class CoreApplicationTest
{
    [Fact]
    public void ProcessInputTest1()
    {
        var mockOutboundPort = new Mock<IOutboundPort>();
        var coreApp = new CoreApp(mockOutboundPort.Object);
        var input = "Test Input";
    }
}