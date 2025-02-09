using Moq;
using PortsAndAdaptersExample.Ports;
using PortsAndAdaptersExample.Application;

namespace PortsAndAdaptersExample.Tests;

public class CoreApplicationTest
{
    [Fact]
    public void ProcessInputTest1()
    {
        var mockOutboundPort = new Mock<IOutboundPort>();
        var coreApp = new CoreApplication(mockOutboundPort.Object);
        var input = "Test Input";
    }
}