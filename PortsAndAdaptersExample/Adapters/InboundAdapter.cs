﻿using PortsAndAdaptersExample.Ports;

namespace PortsAndAdaptersExample.Adapters
{
    public class InboundAdapter
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
