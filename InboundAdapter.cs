using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ports_and_Adapters_example
{
    internal class InboundAdapter: IInboundPort
    {
        private CoreApp coreApp;
        public InboundAdapter(CoreApp coreApp)
        {
            this.coreApp = coreApp;
        }

        void IInboundPort.processInput(string input)
        {
            coreApp.processInput(input);
        }
    }
}
