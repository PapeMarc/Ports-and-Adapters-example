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
            Mock< IInboundPort> mockInboundPort = new Mock<IInboundPort>();
            InboundAdapter adapter = new InboundAdapter(mockInboundPort.Object);
            string input = "Test Input";

            // Act
            adapter.handleInput(input);

            // Assert
            mockInboundPort.Verify(port => port.processInput(input), Times.Once);
        }
    }
}
