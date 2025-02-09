using Ports_and_Adapters_example.CoreApp;

namespace Ports_and_Adapters_example.Infrastructure
{
    internal class InboundAdapter
    {
        private IInboundPort inboundPortApp;
        public InboundAdapter(IInboundPort inboundPortApp)
        {
            this.inboundPortApp = inboundPortApp;
        }

        public void handleInput(string input)
        {
            Console.WriteLine("\n\n[Inbound Adapter]\n");
            Thread.Sleep(1000);
            Console.WriteLine("- Recieved Input: " + input);
            Thread.Sleep(2000);
            Console.WriteLine("- Redirecting to Inbound Port.");
            Thread.Sleep(2000);
            inboundPortApp.processInput(input);
        }
    }
}
