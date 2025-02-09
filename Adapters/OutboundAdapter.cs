using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ports_and_Adapters_example.CoreApp;

namespace Ports_and_Adapters_example.Infrastructure
{
    internal class OutboundAdapter: IOutboundPort
    {
        public void processOutput(string input)
        {
            Console.WriteLine("Output Adapter says: " + input);
        }
    }
}
