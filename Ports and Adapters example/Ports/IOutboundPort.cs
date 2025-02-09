namespace Ports_and_Adapters_example.CoreApp
{
    internal interface IOutboundPort
    {
        public void processOutput(string input);
    }
}
