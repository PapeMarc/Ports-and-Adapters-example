using Microsoft.Extensions.DependencyInjection;
using Ports_and_Adapters_example;

ServiceCollection serviceCollection = new ServiceCollection();
serviceCollection.AddSingleton<IOutboundPort, OutboundAdapter>();
serviceCollection.AddSingleton<CoreApp>(); 

ServiceProvider serviceProvicer =  serviceCollection.BuildServiceProvider();

CoreApp coreApp = serviceProvicer.GetRequiredService<CoreApp>();
IInboundPort inboundPort = new InboundAdapter(coreApp);

inboundPort.processInput("This is my Input :)");