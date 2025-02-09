namespace Ports_and_Adapters_example.CoreApp
{
    internal interface IInboundPort
    {
        public void processInput(string input);
    }
}
