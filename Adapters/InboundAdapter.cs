using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ports_and_Adapters_example.CoreApp;

namespace Ports_and_Adapters_example.Infrastructure
{
    internal class InboundAdapter : IInboundPort
    {
        private CoreApplication coreApp;
        public InboundAdapter(CoreApplication coreApp)
        {
            this.coreApp = coreApp;
        }

        void IInboundPort.processInput(string input)
        {
            coreApp.processInput(input);
        }
    }
}
