namespace PortsAndAdaptersExample.CoreApp
{
    internal class CoreApplication: IInboundPort
    {
        private IOutboundPort outboundPort;
        public CoreApplication(IOutboundPort outboundPort)
        {
            this.outboundPort = outboundPort;
        }

        public void processInput(string input)
        {
            Console.WriteLine("\n\n[Application]\n");
            Thread.Sleep(1000);
            Console.WriteLine("- Recieved Input: " + input);
            Console.Write("- Executing business rules...");

            input = input + "," + input + "," + input + "," + input;

            Thread.Sleep(2000);
            Console.Write("finished.\n");
            Console.Write("- Processing Results...");
            Thread.Sleep(2000);
            Console.Write("finished.\n");
            Console.WriteLine("- Redirecting to outbound Port.");
            Thread.Sleep(2000);

            outboundPort.processOutput(input);
        }

    }
}
