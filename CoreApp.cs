﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ports_and_Adapters_example
{
    internal class CoreApp
    {
        private IOutboundPort outboundPort;
        public CoreApp(IOutboundPort outboundPort)
        {
            this.outboundPort = outboundPort;
        }

        public void processInput(string input)
        {
            Console.WriteLine("Doing something ...");
            Thread.Sleep(1000);
            Console.WriteLine("Doing another thing ..."); 
            Thread.Sleep(1000);
            Console.WriteLine("Done!");
            Thread.Sleep(100);

            outboundPort.processOutput(input);
        }

    }
}
