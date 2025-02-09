using Moq;
using PortsAndAdaptersExample.Ports;
using PortsAndAdaptersExample.Adapters;
using Xunit;

namespace PortsAndAdaptersExample.Tests
{
    public class InputAdapterTest
    {
        [Fact]
        public void InputAdapter_ShouldCallInboundPortWithCorrectInput()
        {
            // Arrange
            var mockInboundPort = new Mock<IInboundPort>();
            var adapter = new InboundAdapter(mockInboundPort.Object);
            var input = "Test Input";

            // Act
            adapter.handleInput(input);

            // Assert
            mockInboundPort.Verify(port => port.processInput(input), Times.Once);
        }
    }
}
