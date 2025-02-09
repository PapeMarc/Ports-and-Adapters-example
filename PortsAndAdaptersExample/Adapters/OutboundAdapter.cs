using PortsAndAdaptersExample.CoreApp;

namespace PortsAndAdaptersExample.Infrastructure
{
    internal class OutboundAdapter: IOutboundPort
    {
        public void processOutput(string output)
        {
            Console.WriteLine("\n\n[Outbound Adapter]\n");
            Console.WriteLine("- Recieved Output: " + output);
            Thread.Sleep(1000);
            Console.WriteLine("- Finished Output processing.");
            Thread.Sleep(2000);
        }
    }
}
