using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ports_and_Adapters_example.CoreApp
{
    internal interface IOutboundPort
    {
        public void processOutput(string input);
    }
}
