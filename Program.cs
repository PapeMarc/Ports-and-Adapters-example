using Ports_and_Adapters_example;

CoreApp coreApp = new CoreApp(new OutboundAdapter());
IInboundPort inboundPort = new InboundAdapter(coreApp);

inboundPort.processInput("This is my Input :)");