namespace PortsAndAdaptersExample.CoreApp
{
    internal interface IOutboundPort
    {
        public void processOutput(string input);
    }
}
