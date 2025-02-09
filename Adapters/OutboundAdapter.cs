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
        public void processOutput(string output)
        {
            Console.WriteLine("\n\n[Outbound Adapter]\n");
            Console.WriteLine("- Recieved Output: " + output);
            Thread.Sleep(1000);
            Console.WriteLine("- Finished Output processing.");
            Thread.Sleep(2000);
            return output;
        }
    }
}
