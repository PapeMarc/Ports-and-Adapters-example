using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            inboundPortApp.processInput(input);
        }
    }
}
