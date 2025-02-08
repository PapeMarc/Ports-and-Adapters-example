using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ports_and_Adapters_example
{
    internal interface IInboundPort
    {
        public void processInput(string input);
    }
}
